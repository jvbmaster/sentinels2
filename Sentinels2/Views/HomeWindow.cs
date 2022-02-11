using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Sentinels2.Data;
using Sentinels2.Models;

namespace Sentinels2.Views
{
    public partial class HomeWindow : Form
    {
        public HomeWindow()
        {
            InitializeComponent();
        }

        private void HomeWindow_Load(object sender, EventArgs e)
        {
            try
            {
                //using (Context ctx = new Context())
                //{
                //    var data = ctx.Vigias.FromSqlRaw($"select * from Vigia").ToList();
                //}   
                dgvVigiasDisponiveis.DataSource = VigiaCRUD.Get(p => p.Turno.Equals("N") || p.Turno.Equals("D")).ToList();
            }
            catch(Exception ex)
            {
                dgvVigiasDisponiveis.DataSource = new List<Vigia>();
                MessageBox.Show($"É aqui que fudeu!\n{ex.Message}");
            }
        }
    }
}
