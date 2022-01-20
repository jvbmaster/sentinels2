using Sentinels2.Models;
using Sentinels2.Data;
using Sentinels2.Rules;
using Sentinels2.Views;
using System.Globalization;
using System.Diagnostics;

namespace Sentinels2
{
    public partial class WorkflowByPerson : Form
    {
        private List<Vigia> vigias = VigiaCRUD.GetAll().ToList();
        private Vigia vigia;
        private int modoExibicao = 0;
        List<string> ids = new List<string>();
        private int idx = 0;

        private ContextMenuStrip menu = new ContextMenuStrip();
        public WorkflowByPerson()
        {
            InitializeComponent();
            opAfastamento.Checked = true;
        }

        private void LoadVigias(string busca = "")
        {
            try
            {
                dgvPessoal.DataSource = (busca == "") 
                    ? vigias : vigias.Where(p => p.Nome.Contains(busca.ToUpper())).ToList();

                for (int i = 1; i <= dgvPessoal.Columns.Count; i++)
                {
                    dgvPessoal.Columns[i].Visible = false;
                }
            }
            catch (Exception ex)
            {
                statusLabel.Text = $"VGM_LOAD: {ex.Message}";
            }
            statusLabel.Text = $"VGM_LOAD: {dgvPessoal.RowCount} de {vigias.Count} carregados";
        }

        private void LoadInfoPanel()
        {
            try
            {
                lbNome.Text = $"{vigia.Nome} ({vigia.Id}) - {DatesWorkflow.IdadePrecisa(vigia.Nascimento)}";
                lbCargo.Text = $"{vigia.Cargo} desde {vigia.Admissao.ToString("dd/MM/yyyy")}";
                lbApelido.Text = $"{DatesWorkflow.TempoDeCasa(vigia.Admissao)} anos de casa";
            }
            catch (Exception)
            {
                lbNome.Text = "Não foi possível carregar os dados";
            }
        }

        private void LoadAfastamentos()
        {
            try
            {
                dgvDataPerson.DataSource = AfastamentoCRUD.Get(p => p.Funcionario.Equals(vigia.Id) && (p.DataInicial >= fDataInicial.Value && p.DataFinal <= fDataFinal.Value))
                    .Select(p => new {
                        p.Id,
                        Tipo = p.TipoAfastamento,
                        Funcionário = p.Funcionario,
                        Início = p.DataInicial.ToString("dd/MM/yyyy"),
                        Fim = p.DataFinal.ToString("dd/MM/yyyy"),
                        QTD = p.QuantidadeDias, 
                        Referência = p.Referencia,
                    }).ToList();
            }
            catch (Exception ex)
            {
                statusLabel.Text = $"LOAD_AFASTAMENTOS: {ex}";
            }
            statusLabel.Text = $"{dgvDataPerson.RowCount} registros";
        }

        private void LoadHoraExtras()
        {
            try
            {
                dgvDataPerson.DataSource = EscalaCRUD.Get(p => p.Vigia.Equals(vigia.Id) && p.TipoPagamento.Equals("EXTRA") && (p.Entrada >= fDataInicial.Value && p.Entrada <= fDataFinal.Value))
                    .OrderBy(p => p.Data)
                    .Select(p => new {
                        p.OS,
                        Data = p.Data.ToString("dd/MM/yyyy"),
                        Dia = p.Data.ToString("ddd", new CultureInfo("pt-BR")).ToUpper(),
                        Entrada = p.Entrada.ToString("HH:mm"),
                        Saída = p.Saida.ToString("HH:mm"),
                        Contabilização = p.TipoPagamento,
                        Substituindo = p.AfastamentoVGF
                    })
                    .ToList();
            }
            catch (Exception ex)
            {
                statusLabel.Text = $"LOAD_HEXTRAS: {ex}";
            }
            statusLabel.Text = $"{dgvDataPerson.RowCount} registros";
        }

        private void LoadHorasTrabalhadas()
        {
            try
            {
                dgvDataPerson.DataSource = EscalaCRUD.Get(p => p.Vigia.Equals(vigia.Id) && (p.Entrada >= fDataInicial.Value && p.Entrada <= fDataFinal.Value))
                    .OrderBy(p => p.Data)
                    .Select(p => new {
                        p.OS,
                        Data = p.Data.ToString("dd/MM/yyyy"),
                        Dia = p.Data.ToString("ddd", new CultureInfo("pt-BR")).ToUpper(),
                        Entrada = p.Entrada.ToString("HH:mm"),
                        Saída = p.Saida.ToString("HH:mm"),
                        Contabilização = p.TipoPagamento,
                        Substituindo = p.AfastamentoVGF
                    })
                    .ToList();
            }
            catch (Exception ex)
            {
                statusLabel.Text = $"LOAD_HEXTRAS: {ex}";
            }
            statusLabel.Text = $"{dgvDataPerson.RowCount} registros";
        }

        public void Afastamentos()
        {
            try
            {
                Relatorios report = new Relatorios();
                Afastamento afastamento = AfastamentoCRUD.Find(dgvDataPerson.CurrentRow.Cells[0].Value.ToString());
                switch (afastamento.TipoAfastamento)
                {
                    case "Abono": report.GerarAbonada(afastamento); break;
                    case "Férias": report.GerarFerias(afastamento); break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private void PrintAfastamento()
        {
            try
            {
                AfastamentoCRUD.ObjectInstanceate = AfastamentoCRUD.Find(dgvDataPerson.CurrentRow.Cells[0].Value);

                Relatorios report = new Relatorios();

                switch (AfastamentoCRUD.ObjectInstanceate.TipoAfastamento)
                {
                    case "Abono": report.GerarAbonada(AfastamentoCRUD.ObjectInstanceate); break;
                    case "Férias": report.GerarFerias(AfastamentoCRUD.ObjectInstanceate); break;
                    case "Licença Prêmio": report.GerarLicencaPremio(AfastamentoCRUD.ObjectInstanceate); break;
                    case "Licença Saúde": report.GerarLicencaMedica(AfastamentoCRUD.ObjectInstanceate); break;
                    case "Casamento": report.GerarAfastamento(AfastamentoCRUD.ObjectInstanceate); break;
                    case "Doação de Sanguê": report.GerarAfastamento(AfastamentoCRUD.ObjectInstanceate); break;
                    case "Paternidade": report.GerarAfastamento(AfastamentoCRUD.ObjectInstanceate); break;
                    case "Luto": report.GerarAfastamento(AfastamentoCRUD.ObjectInstanceate); break;
                    case "TRE": report.GerarAfastamento(AfastamentoCRUD.ObjectInstanceate); break;
                    case "Outros": report.GerarAfastamento(AfastamentoCRUD.ObjectInstanceate); break;
                }

                AbrirArquivoParaImpressao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void PrintOrdemDeServico(string contab = null)
        {
            try
            {
                List<Escala> escalas = (contab == "EXTRA") 
                    ? EscalaCRUD.Get(p => p.Vigia.Equals(vigia.Id) && p.TipoPagamento.Equals(contab) && p.Data >= fDataInicial.Value && p.Data < fDataFinal.Value).OrderBy(p => p.Data).ToList()
                    : EscalaCRUD.Get(p => p.Vigia.Equals(vigia.Id) && p.Data >= fDataInicial.Value && p.Data < fDataFinal.Value).OrderBy(p => p.Data).ToList();
                Relatorios relatorios = new Relatorios();
                relatorios.GerarOrdemDeServico(escalas);
                MessageBox.Show("Cool");

                AbrirArquivoParaImpressao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AbrirArquivoParaImpressao()
        {
            ProcessStartInfo process = new ProcessStartInfo(GlobalsPathApplication.ReaderFileJSON("Globals\\userconfig.json").OfficeApplicationPath);
            process.Arguments = $"{Relatorios.filenametosave}.docx";
            Process.Start(process);
        }

        private void WorkflowByPerson_Load(object sender, EventArgs e)
        {
            int m = DateTime.Now.Month;
            
            fDataInicial.Value = DateTime.Parse($"{DateTime.Now.Year}-{DateTime.Now.Month}-{16}");
            fDataFinal.Value = fDataInicial.Value.AddDays(DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)-1).Date;

            LoadVigias();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadVigias(textBox1.Text);
        }

        private void dgvPessoal_SelectionChanged(object sender, EventArgs e)
        {
            vigia = vigias.Find(p => p.Id.Equals(dgvPessoal.CurrentRow.Cells[0].Value.ToString()));

            LoadInfoPanel();
            switch (modoExibicao)
            {
                case 0: LoadAfastamentos(); break;
                case 1: LoadHoraExtras(); break;
                case 2: LoadHorasTrabalhadas(); break;
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            VigiaCRUD.Loaded = null;
            new NewVigia().ShowDialog();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            try
            {
                VigiaCRUD.Load(vigia.Id);

                new NewVigia().ShowDialog();
            }
            catch (Exception ex)
            {
                statusLabel.Text = $"LOAD_VGM: {ex.Message}";
            }
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            switch (modoExibicao)
            {
                case 0: PrintAfastamento();  break;
                case 1: PrintOrdemDeServico("EXTRA"); break;
                case 2: PrintOrdemDeServico(); break;
            }
        }

        private void opAfastamento_CheckedChanged(object sender, EventArgs e)
        {
            modoExibicao = 0;
            LoadAfastamentos();
        }

        private void opHoraExtra_CheckedChanged(object sender, EventArgs e)
        {
            modoExibicao = 1;
            LoadHoraExtras();
        }

        private void opDiasTrabalhados_CheckedChanged(object sender, EventArgs e)
        {
            modoExibicao = 2;
            LoadHorasTrabalhadas();
        }

        private void dgvDataPerson_MultiSelectChanged(object sender, EventArgs e)
        {
            
        }

        private void PrintFolhaFrequencia()
        {
            vigias.ForEach(v => {
                Relatorios relatorios = new Relatorios();
                relatorios.GerarFolhaFrequencia(v, fDataInicial.Value);
            });
            new Relatorios().GerarOficioFrequencia(fDataInicial.Value);
        }

        private void btFrequencia_Click(object sender, EventArgs e)
        {
            try
            {
                Thread th = new Thread(
                        new ThreadStart(
                            PrintFolhaFrequencia
                        ));
                th.Start();

                MessageBox.Show("Cool");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao tentar gerar Folhas de Frequência\nErro: {ex.Message}");
            }
        }

        public void EnviarPlantoesParaUmaPessoa()
        {
            try
            {
                List<Escala> escalas = EscalaCRUD.Get(p => p.Vigia.Equals(vigia.Id) && p.TipoPagamento.Equals("EXTRA") && p.Data >= fDataInicial.Value && p.Data < fDataFinal.Value).OrderBy(p => p.Data).ToList();
                PersonWorkflow.SendMsgTo(escalas);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao enviar Plantões\nErro: {ex.Message}");
            }
        }

        public void EnviarPlantoesParaTodos()
        {
            try
            {
                vigias.ForEach(v => {
                    List<Escala> escalas = EscalaCRUD.Get(p => p.Vigia.Equals(v.Id) && p.TipoPagamento.Equals("EXTRA") && p.Data >= fDataInicial.Value && p.Data < fDataFinal.Value).OrderBy(p => p.Data).ToList();
                    PersonWorkflow.SendMsgTo(escalas);
                });
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Falha ao enviar plantões\nERRO: {ex.Message}");
            }
        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Função em desenvolvimento\nem breve essa função estará disponível!\nCooming Soon!");
            return;
            try
            {
                Thread th = new Thread(
                        new ThreadStart(
                            EnviarPlantoesParaTodos
                        ));
                th.Start();

                MessageBox.Show("Cool");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao enviar Plantões\nErro: {ex.Message}");
            }
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            EnviarPlantoesParaUmaPessoa();
        }
    }
}