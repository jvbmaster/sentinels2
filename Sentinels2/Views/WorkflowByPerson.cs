using Sentinels2.Models;
using Sentinels2.Data;
using Sentinels2.Rules;
using Sentinels2.Views;
using System.Diagnostics;
using Xceed.Document.NET;

namespace Sentinels2
{
    public partial class WorkflowByPerson : Form
    {
        private List<Vigia> vigias = VigiaCRUD.GetAll().ToList();
        private Vigia v;
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
                lbNome.Text = $"{v.Nome} ({v.Id}) - {DatesWorkflow.IdadePrecisa(v.Nascimento)}";
                lbCargo.Text = $"{v.Cargo} desde {v.Admissao.ToString("dd/MM/yyyy")}";
                lbApelido.Text = $"{DatesWorkflow.TempoDeCasa(v.Admissao)} anos de casa";
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
                dgvDataPerson.DataSource = AfastamentoCRUD.Get(p => p.Funcionario.Equals(v.Id)).ToList();
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
                dgvDataPerson.DataSource = EscalaCRUD.Get(p => p.Vigia.Equals(v.Id) && p.TipoPagamento.Equals("EXTRA")).OrderBy(p => p.Data).ToList();
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

        public void OrdemDeServico()
        {
            try
            {
                List<Escala> escalas = EscalaCRUD.Get(p => p.Vigia.Equals("BARBIERI") && p.TipoPagamento.Equals("EXTRA") && p.Data >= DateTime.Parse("2022-01-01") && p.Data < DateTime.Parse("2022-01-15")).OrderBy(p => p.Data).ToList();
                Relatorios relatorios = new Relatorios();
                relatorios.GerarOrdemDeServico(escalas);
                MessageBox.Show("Cool");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WorkflowByPerson_Load(object sender, EventArgs e)
        {
            LoadVigias();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadVigias(textBox1.Text);
        }

        private void dgvPessoal_SelectionChanged(object sender, EventArgs e)
        {
            v = vigias.Find(p => p.Id.Equals(dgvPessoal.CurrentRow.Cells[0].Value.ToString()));

            LoadInfoPanel();
            switch (modoExibicao)
            {
                case 0: LoadAfastamentos(); break;
                case 1: LoadHoraExtras(); break;
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
                VigiaCRUD.Load(v.Id);

                new NewVigia().ShowDialog();
            }
            catch (Exception ex)
            {
                statusLabel.Text = $"LOAD_VGM: {ex.Message}";
            }
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"");
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

        private void dgvDataPerson_MultiSelectChanged(object sender, EventArgs e)
        {
            
        }
    }
}