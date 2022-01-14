using System.Data;
using Sentinels2.Data;
using Sentinels2.Models;
using Sentinels2.Rules;

namespace Sentinels2.Views
{
    public partial class SetEscalaFixa : Form
    {
        public SetEscalaFixa()
        {
            InitializeComponent();
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<PassaAgulha>  lista = PassaAgulhaCRUD.GetAll().ToList();

            MessageBox.Show($"{DateCheck.Dates.Count} datas carregadas");

            foreach (var item in lista)
            {
                PersonWorkflow.Designate(
                       item.Predio,
                       DateCheck.Dates[0].Date,
                       DateCheck.Dates[DateCheck.Dates.Count-1].Date,
                       item.Par,
                       item.Impar,
                       item.Turno
                   );
            }
           
            MessageBox.Show("Completo");
            Close();
        }

        private void SetEscalaFixa_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PassaAgulhaCRUD.GetAll().ToList();
        }
    }
}
