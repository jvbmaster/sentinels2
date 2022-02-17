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
            
        }

        private void calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            CarregarDemanda();
        }

        private void CarregarDemanda()
        {
            try
            {
                dgvDemanda.DataSource = EscalaCRUD
                    .Get(p => p.Data.Equals(calendar.SelectionStart))
                    .Select(p => new {
                        p.OS,
                        Data = p.Data.ToString("dd/MM"),
                        p.Patrimonio,
                        Horário = $"{p.Entrada.ToString("HH:mm")} às {p.Saida.ToString("HH:mm")}",
                        p.Vigia,
                        p.TipoPagamento
                    }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}
