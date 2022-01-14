using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sentinels2.Models;

namespace Sentinels2.Views
{
    public partial class Repo : Form
    {
        public Repo()
        {
            InitializeComponent();
        }

        private void Repo_Load(object sender, EventArgs e)
        {
            DateCheck dateCheck;
            for(int i = 0; i < 10; i++)
            {
                dateCheck = new DateCheck();
                dateCheck.Date = DateTime.Now.AddDays(i);
                dateCheck.Checked = true;
                DateCheck.Dates.Add(dateCheck);
            }
            
            checkedListBox1.Items.Clear();

            DateCheck.Dates.ForEach(e => {
                checkedListBox1.Items.Add(e.Date.ToString("dd/MMMM/yyyy ddd", new CultureInfo("pt-BR")), e.Checked);
            });

            checkedListBox1.Click += CheckedListBox1_Click;
        }

        private void CheckedListBox1_Click(object? sender, EventArgs e)
        {
        }
    }
}
