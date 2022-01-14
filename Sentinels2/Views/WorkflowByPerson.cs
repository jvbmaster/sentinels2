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
        public WorkflowByPerson()
        {
            InitializeComponent();
        }

        private void LoadVigias(string busca = "")
        {
            try
            {
                dgvPessoal.DataSource = (busca == "") 
                    ? VigiaCRUD.GetAll().ToList() 
                    : VigiaCRUD.Get(p => p.Nome.Contains(busca.ToUpper())).ToList();
                for (int i = 1; i <= dgvPessoal.Columns.Count; i++)
                {
                    dgvPessoal.Columns[i].Visible = false;
                }
            }
            catch (Exception ex)
            {
                statusLabel.Text = $"VGM_LOAD: {ex.Message}";
            }
        }

        private void LoadInfoPanel()
        {
            try
            {
                lbNome.Text = dgvPessoal.CurrentRow.Cells["Nome"].Value.ToString();
                lbApelido.Text = dgvPessoal.CurrentRow.Cells["Id"].Value.ToString();
                lbCargo.Text = dgvPessoal.CurrentRow.Cells["Cargo"].Value.ToString();
                lbAdimissao.Text = DateTime.Parse(dgvPessoal.CurrentRow.Cells["Admissao"].Value.ToString()).ToString("dd/MM/yyyy");
                lbTempoDeCasa.Text = $"{DatesWorkflow.TempoDeCasa(DateTime.Parse(dgvPessoal.CurrentRow.Cells["Admissao"].Value.ToString()))} anos de casa";
                lbIdade.Text = DatesWorkflow.IdadePrecisa(DateTime.Parse(dgvPessoal.CurrentRow.Cells["Nascimento"].Value.ToString()));
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
                dgvAfastamentos.DataSource = AfastamentoCRUD.Get(p => p.Funcionario.Equals(dgvPessoal.CurrentRow.Cells[0].Value.ToString())).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }


        public void Afastamentos()
        {
            try
            {
                Relatorios report = new Relatorios();
                Afastamento afastamento = AfastamentoCRUD.Find(dgvAfastamentos.CurrentRow.Cells[0].Value.ToString());
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
            LoadInfoPanel();
            switch (tabControl2.SelectedIndex)
            {
                case 0: LoadAfastamentos(); break;
                case 1: statusLabel.Text = $"TB_CTRL: {tabControl2.SelectedIndex}"; break;
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
                VigiaCRUD.Load(dgvPessoal.CurrentRow.Cells[0].Value.ToString());

                new NewVigia().ShowDialog();
            }
            catch (Exception ex)
            {
                statusLabel.Text = $"LOAD_VGM: {ex.Message}";
            }
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tudo certo aqui");
        }
    }
}