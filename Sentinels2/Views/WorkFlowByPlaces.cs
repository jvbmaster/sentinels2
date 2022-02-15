using System.Data;
using System.Globalization;
using Sentinels2.Data;
using Sentinels2.Models;
using Sentinels2.Rules;
using Sentinels2.Tools;

namespace Sentinels2.Views
{
    public partial class WorkFlowByPlaces : Form
    {
        private List<Patrimonio> patrimonios = PatrimonioCRUD.GetAll().OrderBy(p => p.Id).ToList();
        private Patrimonio patrimonio;
        private DateTime dataInicial, dataFinal;
        private ContextMenuStrip menu = new ContextMenuStrip();
        private string periodos = "A";
        private Afastamento afastamento;
        public WorkFlowByPlaces()
        {
            InitializeComponent();
        }

        private void LoadPlaces(string search = "")
        {
            try
            {
                var data = (search == "") ? patrimonios : patrimonios.Where(p => p.Id.Contains(fSearch.Text)).ToList();
                dgvPlaces.DataSource = data.OrderBy(p => p.Titulo).ToList();
                statusLabel.Text = $"{patrimonios.Count} patrimônios cadastrados";
                for (int i = 1; i < dgvPlaces.Columns.Count; i++)
                {
                    dgvPlaces.Columns[i].Visible = false;
                }
            }
            catch (Exception ex)
            {
                statusLabel.Text = $"PLACES: {ex.Message}";
            }
        }

        private void LoadDates()
        {
            try
            {
                patrimonio = PatrimonioCRUD.Find(p => p.Id.Equals(dgvPlaces.CurrentRow.Cells[0].Value));

                var data = EscalaCRUD.Get(p => p.Patrimonio.Equals(patrimonio.Id)).OrderByDescending(p => p.Data);
                var dataf = data.ToList();

                switch (periodos)
                {
                    case "A": dataf = data.ToList(); break;
                    case "D": dataf = data.Where(x => x.Saida.Hour > x.Entrada.Hour).ToList(); break;
                    case "N": dataf = data.Where(x => x.Saida.Hour < x.Entrada.Hour).ToList(); break;
                }

                dgvDates.DataSource = dataf
                    .Select(p => new {
                        p.OS,
                        Data = p.Data.ToString("dd/MM/yyyy"),
                        Dia = p.Data.ToString("ddd", new CultureInfo("pt-BR")).ToUpper(),
                        Entrada = p.Entrada.ToString("HH:mm"),
                        Saída = p.Saida.ToString("HH:mm"),
                        Guarnição = p.Vigia,
                        Contabilização = p.TipoPagamento,
                        Substituição = p.AfastamentoVGF
                }).ToList();

                dgvDates.Columns[0].Visible = false;

                int afastamentoId = 0;
                string vgmescalado = "";
                foreach (DataGridViewRow row in dgvDates.Rows)
                {
                    afastamentoId = Convert.ToInt32(row.Cells[7].Value);
                    if (afastamentoId > 0)
                    {
                        afastamento = AfastamentoCRUD.Find(afastamentoId);
                        vgmescalado = row.Cells[5].Value.ToString();
                        row.DefaultCellStyle.BackColor = (vgmescalado == afastamento.Funcionario) ? Color.Red : Color.LightGreen;
                    }
                }
            }
            catch (Exception ex)
            {
                statusLabel.Text = $"ESCALAS: {ex.Message}";
            }
        }
        private void VerificarDisponibilidade()
        {
            try
            {
                DateTime dt = DateTime.Parse(dgvDates.CurrentRow.Cells[1].Value.ToString());
                // Apenas Vigias Disponíveis
                List<Vigia> vigias = PersonWorkflow.AvailableOnDate(dt, periodos);
                // Apenas Escalas pagas como EXTRA no período especificado
                List<Escala> escalas = EscalaCRUD.Get(p => p.TipoPagamento.Equals("EXTRA") && (p.Data >= fDataInicial.Value.Date && p.Data <= fDataFinal.Value.Date)).ToList();

                var data = from v in vigias
                           let t = escalas.Where(x => x.Vigia.Equals(v.Id)).Count()
                           let d = escalas.Where(x => x.Vigia.Equals(v.Id)).Sum(x => x.Duracao.TotalHours)
                           // let aux_u = escalas.Where(x => x.Vigia.Equals(v.Id)).Last()
                           select new {
                               Disponivéis = v.Id,
                               Plantões = t,
                               Horas = d
                               //Ultimo_Realizado = aux_u.Data
                           };

                dgvPersons.DataSource = data.ToList();

                //dgvPersons.DataSource = PersonWorkflow.AvailableOnDate(dt)
                //    .Select(p => new {
                //        Disponíveis = p.Id
                //    }).ToList();
            }
            catch (Exception ex)
            {
                statusLabel.Text += $"DISPO: {ex.Message}";
            }
        }

        private void EscalarExtra(object sender, EventArgs e)
        {
            try
            {
                PersonWorkflow.Escalar(int.Parse(dgvDates.CurrentRow.Cells[0].Value.ToString()),
                                        dgvPersons.CurrentRow.Cells[0].Value.ToString(),
                                        "EXTRA");
                LoadDates();
                VerificarDisponibilidade();
            }
            catch (Exception ex)
            {

                statusLabel.Text += $"escalar: {ex.Message}";
            }
        }

        private void EscalarNormal(object sender, EventArgs e)
        {
            try
            {
                PersonWorkflow.Escalar(int.Parse(dgvDates.CurrentRow.Cells[0].Value.ToString()),
                                       dgvPersons.CurrentRow.Cells[0].Value.ToString(),
                                       "NORMAL");
                LoadDates();
                VerificarDisponibilidade();
            }
            catch (Exception ex)
            {

                statusLabel.Text += $"escalar: {ex.Message}";
            }
        }

        private void EscalarTroca(object sender, EventArgs e)
        {
            try
            {
                PersonWorkflow.Escalar(int.Parse(dgvDates.CurrentRow.Cells[0].Value.ToString()),
                                       dgvPersons.CurrentRow.Cells[0].Value.ToString(),
                                       "TROCA");
                LoadDates();
                VerificarDisponibilidade();
            }
            catch (Exception ex)
            {

                statusLabel.Text += $"escalar: {ex.Message}";
            }
        }
        private void LoadPlantoesPorVGM()
        {
            try
            {
                string vgm = dgvPersons.CurrentRow.Cells[0].Value.ToString();
                dgvPlVgm.DataSource = EscalaCRUD.Get(p => p.Vigia.Equals(vgm) && p.TipoPagamento.Equals("EXTRA") && (p.Data >= fDataInicial.Value.Date && p.Data <= fDataFinal.Value.Date))
                    .Select(p => new {
                        p.Data,
                        p.Patrimonio
                    })
                    .ToList();
                plVgm.Text = $"Plantões de {vgm}";
            }
            catch (Exception ex)
            {
                statusLabel.Text = $"PL_VGM: {ex.Message}";
            }
        }

        private void EditarPatrimonio(object sender, EventArgs e)
        {
            PatrimonioCRUD.ObjectInstanceate = patrimonio;
            if(new AddPatrimonio().ShowDialog() == DialogResult.OK)
            {
                LoadPlaces();
            }
        }

        private void WorkFlowByPlaces_Load(object sender, EventArgs e)
        {
            opTodos.Checked = true;
            DateTime dataInicial = DateTime.Parse($"{DateTime.Now.Year}-{DateTime.Now.AddMonths(-1).Month}-{16}");
            DateTime dataFinal = dataInicial.AddDays(DateTime.DaysInMonth(DateTime.Now.Year, dataInicial.Month) - 1).Date;
            fDataInicial.Value = dataInicial;
            fDataFinal.Value = dataFinal;
            LoadPlaces();
        }

        private void dgvPlaces_SelectionChanged(object sender, EventArgs e)
        {
            LoadDates();
        }

        private void fSearch_TextChanged(object sender, EventArgs e)
        {
            LoadPlaces(fSearch.Text);
        }

        private void dgvDates_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvDates_MouseClick(object sender, MouseEventArgs e)
        {
            if(todosVigias.Checked == true)
            {
                dgvPersons.DataSource = VigiaCRUD.GetAll().OrderBy(p => p.Id).Select(p => new {
                    TODOS = p.Id
                }).ToList();
            }
            else
            {
                VerificarDisponibilidade();
            }
            gSubstituicoes.Text = $"Substituição para {dgvDates.CurrentRow.Cells["Data"].Value}";
            afastamento = (int.Parse(dgvDates.CurrentRow.Cells["Substituição"].Value.ToString()) > 0) ? AfastamentoCRUD.Find(dgvDates.CurrentRow.Cells["Substituição"].Value) : null;
            lbSubsituicao.Text = (afastamento == null) ? "" : $"{afastamento.TipoAfastamento} de {afastamento.Funcionario}";
        }

        private void dgvPersons_MouseClick(object sender, MouseEventArgs e)
        {
            LoadPlantoesPorVGM();
        }

        private void opTodos_CheckedChanged(object sender, EventArgs e)
        {
            periodos = "A";
            LoadDates();
        }

        private void opDiurno_CheckedChanged(object sender, EventArgs e)
        {
            periodos = "D";
            LoadDates();
        }

        private void opNoturno_CheckedChanged(object sender, EventArgs e)
        {
            periodos = "N";
            LoadDates();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            PatrimonioCRUD.ObjectInstanceate = null;
            if(new AddPatrimonio().ShowDialog() == DialogResult.OK)
            {
                LoadPlaces();
            }
        }

        private void dgvPlaces_MouseCaptureChanged(object sender, EventArgs e)
        {
            ContextMenuOnPlaces();
        }

        private void dgvDates_MouseCaptureChanged(object sender, EventArgs e)
        {
            dgvDates.AccessibilityObject.HitTest(MousePosition.X, MousePosition.Y).Select(AccessibleSelection.TakeSelection);
            ContextMenuOnDates();
        }

        private void ContextMenuOnDates()
        {
            ToolStripMenuItem item1 = new ToolStripMenuItem("Editar");
            ToolStripMenuItem item2 = new ToolStripMenuItem("Excluir");
            ToolStripMenuItem item3 = new ToolStripMenuItem("Limpar Escala");

            item1.Click += EditarRegistro;
            item2.Click += ExcluirRegistro;
            item3.Click += LimparEscala;

            menu.Items.Clear();
            menu.Items.Add(item1);
            menu.Items.Add(item2);
            menu.Items.Add(item3);

            dgvDates.ContextMenuStrip = menu;
        }

        private void LimparEscala(object? sender, EventArgs e)
        {
            try
            {
                Escala escala = EscalaCRUD.Find(int.Parse(dgvDates.CurrentRow.Cells[0].Value.ToString()));
                escala.Vigia = "";
                EscalaCRUD.Update(escala);
                LoadDates();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível modificar os dados\nErro: {ex.Message}");
            }
        }

        private void ExcluirRegistro(object? sender, EventArgs e)
        {
            try
            {
                int os = int.Parse(dgvDates.CurrentRow.Cells[0].Value.ToString());
                EscalaCRUD.Delete(os);
                LoadDates();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível excluir os dados\nErro: {ex.Message}");
            }
        }

        private void EditarRegistro(object? sender, EventArgs e)
        {
            try
            {
                int os = int.Parse(dgvDates.CurrentRow.Cells[0].Value.ToString());
                EscalaCRUD.ObjectInstanceate = EscalaCRUD.Find(os);
                if(new EditEscala().ShowDialog() == DialogResult.OK)
                {
                   LoadDates();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível excluir os dados\nErro: {ex.Message}");
            }
        }
        private void dgvPersons_MouseCaptureChanged(object sender, EventArgs e)
        {
            //MasterForm.SetRowOnRightClick(dgvPersons);
            dgvPersons.AccessibilityObject.HitTest(MousePosition.X, MousePosition.Y).Select(AccessibleSelection.TakeSelection);
            ContextMenuOnPersons();
        }
    }
}
