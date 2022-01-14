using System.Data;
using Sentinels2.Data;
using Sentinels2.Models;
using Sentinels2.Rules;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Sentinels2.Views
{
    public partial class WorkflowByDate : Form
    {
        private int totalDays = 0;
        public WorkflowByDate()
        {
            InitializeComponent();
        }

        private void WorkflowByDate_Load(object sender, EventArgs e)
        {
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
                
                dgvEscala.DataSource = data.Select(p => new {
                        p.OS,
                        Data = p.Data.ToString("dd/MM/yyyy"),
                        Local = p.Patrimonio,
                        Entrada = p.Entrada.ToString("HH:mm"),
                        Saída = p.Saida.ToString("HH:mm"),
                        Guarnição = p.Vigia,
                        Contabilização = p.TipoPagamento,
                        Duração = p.Duracao
                    }).ToList();;
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
                dgvPessoalDisponivel.DataSource = (totalDays > 1) ? null : PersonWorkflow.AvailableOnDate(calendar.SelectionStart)
                    .Select(p => new {
                        Disponíveis = p.Id
                    }).ToList();
            }
            catch (Exception ex)
            {
                statusLabel.Text += $"dispo: {ex.Message}";
            }
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
            AfastamentoCRUD.ObjectInstanceate.DataInicial = calendar.SelectionStart;
            AfastamentoCRUD.ObjectInstanceate.QuantidadeDias = totalDays;
            AfastamentoCRUD.ObjectInstanceate.DataFinal = (totalDays > 1) ? calendar.SelectionEnd : calendar.SelectionStart;
            new SetVigia().ShowDialog();
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

        private void zerarOrdensDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (Context context = new Context())
                {
                    var data = context.Escalas.FromSqlRaw("UPDATE SQLITE_SEQUENCE SET SEQ=0 WHERE NAME='Escala'").ToList();
                }
                MessageBox.Show("Cool");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
