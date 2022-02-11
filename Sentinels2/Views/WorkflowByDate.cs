using System.Data;
using System.Diagnostics;
using System.Globalization;
using Sentinels2.Data;
using Sentinels2.Models;
using Sentinels2.Rules;

namespace Sentinels2.Views
{
    public partial class WorkflowByDate : Form
    {
        private int totalDays = 0;
        private string periodos = "A";
        private Afastamento afastamento;
        public WorkflowByDate()
        {
            InitializeComponent();
            opTodos.Checked = true;
        }

        private void WorkflowByDate_Load(object sender, EventArgs e)
        {
            DateTime dataInicial = DateTime.Parse($"{DateTime.Now.Year}-{DateTime.Now.AddMonths(-1).Month}-{16}");
            DateTime dataFinal = dataInicial.AddDays(DateTime.DaysInMonth(DateTime.Now.Year, dataInicial.Month) - 1).Date;
            
            fDataInicial.Value = dataInicial;
            fDataFinal.Value = dataFinal;

            calendar.SelectionStart = DateTime.Now;
            LoadDataFromDate();
        }

        private void LoadDataFromDate()
        {
            try
            {
                var data = (totalDays > 1)
                     ? EscalaCRUD.Get(p => p.Data >= calendar.SelectionStart && p.Data <= calendar.SelectionEnd)
                     : EscalaCRUD.Get(p => p.Data.Equals(calendar.SelectionStart));
                
                var dataf = data;
                
                switch (periodos)
                {
                    case "A": dataf = data; break;
                    case "D": dataf = data.Where(x => x.Saida.Hour > x.Entrada.Hour); break;
                    case "N": dataf = data.Where(x => x.Saida.Hour < x.Entrada.Hour); break;
                }

                dgvEscala.DataSource = dataf.Select(p => new {
                        p.OS,
                        Local = p.Patrimonio,
                        Data = p.Data.ToString("dd/MM/yyyy"),
                        Dia = p.Data.ToString("ddd", new CultureInfo("pt_BR")).ToUpper(),
                        Entrada = p.Entrada.ToString("HH:mm"),
                        Saída = p.Saida.ToString("HH:mm"),
                        Guarnição = p.Vigia,
                        Contabilização = p.TipoPagamento,
                        Duração = p.Duracao,
                        Substituição = p.AfastamentoVGF
                    }).OrderBy(p => p.Local).ToList();

                int afastamentoId = 0;
                string vgmescalado = "";
                foreach (DataGridViewRow row in dgvEscala.Rows)
                {
                    afastamentoId = Convert.ToInt32(row.Cells[9].Value);
                    if (afastamentoId > 0)
                    {
                        afastamento = AfastamentoCRUD.Find(afastamentoId);
                        vgmescalado = row.Cells[6].Value.ToString();
                        row.DefaultCellStyle.BackColor = (vgmescalado == afastamento.Funcionario || vgmescalado == "") ? Color.Red : Color.LightGreen;
                    }
                }

            }
            catch (Exception ex)
            {
                statusLabel.Text += $"ESCALA_LOAD: {ex.Message}";
            }
        }
        private void VerificarDisponibilidade()
        {
            try
            {
                // Apenas Vigias Disponíveis
                List<Vigia> vigias = PersonWorkflow.AvailableOnDate(calendar.SelectionStart, periodos);
                // Apenas Escalas pagas como EXTRA no período especificado
                List<Escala> escalas = EscalaCRUD.Get(p => p.TipoPagamento.Equals("EXTRA") && (p.Data >= fDataInicial.Value.Date && p.Data <= fDataFinal.Value.Date) ).ToList();

                var data = from v in vigias
                           let t = escalas.Where(x => x.Vigia.Equals(v.Id)).Count()
                           let d = escalas.Where(x => x.Vigia.Equals(v.Id)).Sum(x => x.Duracao.TotalHours)
                           //let aux_u = escalas.Where(x => x.Vigia.Equals(v.Id)).Last()
                           select new {
                               Disponivéis = v.Id,
                               Plantões = t,
                               Horas = d,
                               //Ultimo_Realizado = aux_u.Data
                           };

                dgvPessoalDisponivel.DataSource = data.ToList();
            }
            catch (Exception ex)
            {
                statusLabel.Text = $"DISPO: {ex.Message}";
            }
           // try
           // {
           //     dgvPessoalDisponivel.DataSource = (totalDays > 1) ? null : PersonWorkflow.AvailableOnDate(calendar.SelectionStart)
           //         .Select(p => new {
           //             Disponíveis = p.Id
           //         }).ToList();
           // }
           // catch (Exception ex)
           // {
           //     statusLabel.Text += $"dispo: {ex.Message}";
           // }
        }
        private void AdicionarPlantao(object sender, EventArgs e)
        {
            CarregarListaDeDatas();

            if(new EscalaScreen().ShowDialog() == DialogResult.OK)
            {
                LoadDataFromDate();
            }
        }

        private void CarregarListaDeDatas()
        {
            DateCheck.Dates = new List<DateCheck>();
            DateCheck currentDate;
            DateTime dateStart = calendar.SelectionRange.Start;

            for (int i = 0; i < totalDays; i++)
            {
                currentDate = new DateCheck();
                currentDate.Checked = true;
                currentDate.Date = dateStart.AddDays(i);
                DateCheck.Dates.Add(currentDate);
            }
        }

        private void DesignarVigiasFixos(object sender, EventArgs e)
        {
            CarregarListaDeDatas();
            new SetEscalaFixa().ShowDialog();
        }

        private void AdicionarAfastamento(object sender, EventArgs e)
        {
            AfastamentoCRUD.ObjectInstanceate = new Afastamento();
            AfastamentoCRUD.ObjectInstanceate.DataInicial = calendar.SelectionStart.Date;
            AfastamentoCRUD.ObjectInstanceate.QuantidadeDias = totalDays;
            AfastamentoCRUD.ObjectInstanceate.DataFinal = (totalDays > 1) ? calendar.SelectionEnd.Date : calendar.SelectionStart.Date;
            
            if(new AddAfastamento().ShowDialog() == DialogResult.Yes)
            {
                ProcessStartInfo process = new ProcessStartInfo(GlobalsPathApplication.ReaderFileJSON("Globals\\userconfig.json").OfficeApplicationPath);
                process.Arguments = $"{Relatorios.filenametosave}.docx";
                Process.Start(process);
            }
        }

        private void AdicionarLembrete(object sender, EventArgs e)
        {
            
        }

        private void AdicionarFeriado(object sender, EventArgs e)
        {
            
        }
        private void EscalarExtra(object sender, EventArgs e)
        {
            try
            {
                PersonWorkflow.Escalar(int.Parse(dgvEscala.CurrentRow.Cells[0].Value.ToString()), 
                                        dgvPessoalDisponivel.CurrentRow.Cells[0].Value.ToString(), 
                                        "EXTRA");
                LoadDataFromDate();
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
                PersonWorkflow.Escalar(int.Parse(dgvEscala.CurrentRow.Cells[0].Value.ToString()),
                                       dgvPessoalDisponivel.CurrentRow.Cells[0].Value.ToString(),
                                       "NORMAL");
                LoadDataFromDate();
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
                PersonWorkflow.Escalar(int.Parse(dgvEscala.CurrentRow.Cells[0].Value.ToString()),
                                       dgvPessoalDisponivel.CurrentRow.Cells[0].Value.ToString(),
                                       "TROCA");
                LoadDataFromDate();
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
                string vgm = dgvPessoalDisponivel.CurrentRow.Cells[0].Value.ToString();
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
        /// <Eventos>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 


        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            totalDays = (int) (calendar.SelectionRange.End - calendar.SelectionRange.Start).TotalDays + 1;
            lbTotalDays.Text = (totalDays > 1) ? $"{totalDays} dias" : $"{totalDays} dia";
        }

        private void calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            lbCurrentDate.Text = calendar.SelectionStart.ToString("D");
            LoadDataFromDate();
            VerificarDisponibilidade();
        }

        private void dgvPessoalDisponivel_MouseClick(object sender, MouseEventArgs e)
        {
            LoadPlantoesPorVGM();
        }

        private void opTodos_CheckedChanged(object sender, EventArgs e)
        {
            periodos = "A";
            LoadDataFromDate();
        }

        private void opDiurno_CheckedChanged(object sender, EventArgs e)
        {
            periodos = "D";
            LoadDataFromDate();
        }

        private void dgvEscala_MouseCaptureChanged(object sender, EventArgs e)
        {
            dgvEscala.AccessibilityObject.HitTest(MousePosition.X, MousePosition.Y).Select(AccessibleSelection.TakeSelection);
            ContextMenuOnEscala();
        }

        private void ContextMenuOnEscala()
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

            dgvEscala.ContextMenuStrip = menu;
        }

        private void LimparEscala(object? sender, EventArgs e)
        {
            try
            {
                Escala escala = EscalaCRUD.Find(int.Parse(dgvEscala.CurrentRow.Cells[0].Value.ToString()));
                escala.Vigia = "";
                EscalaCRUD.Update(escala);
                LoadDataFromDate();
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
                int os = int.Parse(dgvEscala.CurrentRow.Cells[0].Value.ToString());
                EscalaCRUD.Delete(os);
                LoadDataFromDate();
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
                int os = int.Parse(dgvEscala.CurrentRow.Cells[0].Value.ToString());
                // Chamar Editor
                LoadDataFromDate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível excluir os dados\nErro: {ex.Message}");
            }
        }

        private void opNoturno_CheckedChanged(object sender, EventArgs e)
        {
            periodos = "N";
            LoadDataFromDate();
        }

    }
}
