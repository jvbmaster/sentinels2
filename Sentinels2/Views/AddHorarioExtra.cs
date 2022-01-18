using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sentinels2.Data;

namespace Sentinels2.Views
{
    public partial class AddHorarioExtra : Form
    {
        public AddHorarioExtra()
        {
            InitializeComponent();
        }

        private void AddHorarioExtra_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DemandaExtraCRUD.ObjectInstanceate = new Models.DemandaExtra();
            DemandaExtraCRUD.ObjectInstanceate.DiaSemana = fDiaSemana.SelectedIndex;
            DemandaExtraCRUD.ObjectInstanceate.Entrada = TimeSpan.Parse(fEntrada.Text);
            DemandaExtraCRUD.ObjectInstanceate.Saida = TimeSpan.Parse(fSaida.Text);
        }
    }
}
