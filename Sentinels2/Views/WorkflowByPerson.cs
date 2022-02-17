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
        private List<Vigia> vigias = VigiaCRUD.Get(p => p.Turno.Equals("N") || p.Turno.Equals("D")).ToList();
        private List<Escala> extras = new List<Escala>();
        private List<Escala> escalaFixa = new List<Escala>();
        private List<Afastamento> afastamentos = new List<Afastamento>();
        private Vigia vigia;
        private int modoExibicao = 0;

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
                List<Vigia> firstFilter = (busca == "") 
                    ? vigias : vigias.Where(p => p.Nome.Contains(busca.ToUpper())).ToList();

                dgvPessoal.DataSource = firstFilter.OrderBy(p => p.Id).ToList();

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
                afastamentos = AfastamentoCRUD.Get(p => p.Funcionario.Equals(vigia.Id) && (p.DataInicial >= fDataInicial.Value && p.DataFinal <= fDataFinal.Value))
                    .ToList();

                dgvDataPerson.DataSource = afastamentos.Select(p => new {
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
                extras = EscalaCRUD.Get(p => p.Vigia.Equals(vigia.Id) && p.TipoPagamento.Equals("EXTRA") && (p.Entrada >= fDataInicial.Value && p.Entrada <= fDataFinal.Value))
                    .OrderBy(p => p.Data).ToList();

                dgvDataPerson.DataSource = extras
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
                escalaFixa = EscalaCRUD.Get(p => p.Vigia.Equals(vigia.Id) && (p.Entrada >= fDataInicial.Value && p.Entrada <= fDataFinal.Value) && p.TipoPagamento.Equals("NORMAL"))
                    .OrderBy(p => p.Data)
                    
                    .ToList();
                dgvDataPerson.DataSource = escalaFixa
                    .Select(p => new {
                        p.OS,
                        Data = p.Data.ToString("dd/MM/yyyy"),
                        Dia = p.Data.ToString("ddd", new CultureInfo("pt-BR")).ToUpper(),
                        Entrada = p.Entrada.ToString("HH:mm"),
                        Saída = p.Saida.ToString("HH:mm"),
                        Contabilização = p.TipoPagamento,
                        Substituindo = p.AfastamentoVGF
                    }).ToList();
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
            LoadVigias();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadVigias(textBox1.Text);
        }

        private void LoadInfo()
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

        private void dgvPessoal_MouseCaptureChanged(object sender, EventArgs e)
        {
            ContextMenuOnPersons();
        }

        private void dgvDataPerson_MouseCaptureChanged(object sender, EventArgs e)
        {
            ContextMenuOnData();
        }

        private void ContextMenuOnPersons()
        {
            ToolStripMenuItem item1 = new ToolStripMenuItem("Editar");
            item1.Click += (object sender, EventArgs e) => {
                try
                {
                    VigiaCRUD.Load(vigia.Id);

                    new NewVigia().ShowDialog();
                }
                catch (Exception ex)
                {
                    statusLabel.Text = $"LOAD_VGM: {ex.Message}";
                }
            };

            menu.Items.Clear();
            menu.Items.Add(item1);

            dgvPessoal.ContextMenuStrip = menu;
        }

        private void ContextMenuOnData()
        {
            ToolStripMenuItem item1 = new ToolStripMenuItem("Gerar Ordem de Serviço");
            ToolStripMenuItem item2 = new ToolStripMenuItem("Enviar para Telefone");
            ToolStripMenuItem item3 = new ToolStripMenuItem("Imprimir Documento Selecionado");
            ToolStripMenuItem item4 = new ToolStripMenuItem("Editar");
            ToolStripMenuItem item5 = new ToolStripMenuItem("Excluir");

            item1.Click += (object sender, EventArgs e) => {
                MessageBox.Show("Hello");
            };

            item2.Click += (object sender, EventArgs e) => {
                MessageBox.Show("Hello");
            };

            item3.Click += (object sender, EventArgs e) => {
                MessageBox.Show("Hello");
            };

            item4.Click += (object sender, EventArgs e) => {

            };

            item5.Click += (object sender, EventArgs e) => {
                try
                {
                    Afastamento afastamento = AfastamentoCRUD.Find(int.Parse(dgvDataPerson.CurrentRow.Cells[0].Value.ToString()));
                    EscalaCRUD.GetAll().ToList().ForEach(
                        i => {
                            if (i.AfastamentoVGF.Equals(afastamento.Id))
                            {
                                i.AfastamentoVGF = 0;
                                EscalaCRUD.Update(i);
                            }
                        }
                    );
                    AfastamentoCRUD.Delete(afastamento);
                    LoadAfastamentos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Não foi possível excluir os dados\nErro: {ex.Message}");
                }
            };

            menu.Items.Clear();
            if (opHoraExtra.Checked == true)
            {
                menu.Items.Add(item1);
                menu.Items.Add(item2);
                menu.Items.Add(item3);
            }
            if (opAfastamento.Checked == true)
            {
                //menu.Items.Add(item4);
                menu.Items.Add(item5);
            }

            dgvDataPerson.ContextMenuStrip = menu;
        }

        private void dgvPessoal_Click(object sender, EventArgs e)
        {
            LoadInfo();
        }

        private void btConvoc_Click(object sender, EventArgs e)
        {
            
            switch (modoExibicao)
            {
                case 0: FecharFrequencia(); break;
                case 1: FecharHorasExtra(); break;
            }
            
        }

        public void FecharHorasExtra()
        {
            try
            {
                FechamentoHoraExtra fechamento = new FechamentoHoraExtra(vigia, fDataInicial.Value, fDataFinal.Value);
                foreach (var item in extras)
                {
                    fechamento.Analisar(item);
                }
                MessageBox.Show("Nenhuma quebra!");

                dgvDataPerson.DataSource = fechamento.Convocacao.HorasRealizadas.Select(p => new {
                    Data = p.Data.ToString("dd/MM"),
                    Horario = $"{p.Entrada.ToString("HH:mm")} às {p.Saida.ToString("HH:mm")}",
                    p.SimplesDiurna,
                    p.SimplesNoturna,
                    p.PlantaoDiurna,
                    p.PlantaoNoturna,
                    p.Justificativa
                }).ToList();

                if (MessageBox.Show("Podemos prosseguir para a impressão do documento ?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Relatorios r = new Relatorios();
                    r.GerarConvocacao(fechamento);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oh, fézes!\n\n{ex.Message}");
            }
        }

        public void FecharFrequencia()
        {
            LoadHorasTrabalhadas();
            LoadAfastamentos();
            try
            {
                Relatorios r = new Relatorios();
                r.FecharFolhaFrequencia(vigia, afastamentos, escalaFixa);

                ProcessStartInfo process = new ProcessStartInfo(GlobalsPathApplication.ReaderFileJSON("Globals\\userconfig.json").OfficeApplicationPath);
                process.Arguments = $"{Relatorios.filenametosave}.docx";
                Process.Start(process);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oh, fézes!\n\n{ex.Message}");
            }
        }
    }
}