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
using Sentinels2.Models;

namespace Sentinels2.Views
{
    public partial class AddDemanda : Form
    {
        private List<int> _diasSemana = new List<int>();

        public AddDemanda()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AdicionarDemanada()
        {
            foreach (var item in _diasSemana)
            {
                DemandaExtra de = new DemandaExtra();
                de.Patrimonio = PatrimonioCRUD.Loaded.Id;
                de.Entrada = TimeSpan.Parse(fEntrada.Text);
                de.Saida = TimeSpan.Parse(fSaida.Text);
                de.DiaSemana = item;
                DemandaExtraCRUD.Insert(de);
            }
        }

        private void AddDemanda_Load(object sender, EventArgs e)
        {
            lbPatrimonio.Text = PatrimonioCRUD.Loaded.Titulo.ToString();
            CarregarDemanda();
        }

        private void domingo_CheckedChanged(object sender, EventArgs e)
        {
            if (domingo.Checked)
            {
                _diasSemana.Add(0);
            }
            else
            {
                _diasSemana.Remove(0);
            }
        }

        private void segunda_CheckedChanged(object sender, EventArgs e)
        {
            if (segunda.Checked)
            {
                _diasSemana.Add(1);
            }
            else
            {
                _diasSemana.Remove(1);
            }
        }

        private void terca_CheckedChanged(object sender, EventArgs e)
        {
            if (terca.Checked)
            {
                _diasSemana.Add(2);
            }
            else
            {
                _diasSemana.Remove(2);
            }
        }

        private void quarta_CheckedChanged(object sender, EventArgs e)
        {
            if (quarta.Checked)
            {
                _diasSemana.Add(3);
            }
            else
            {
                _diasSemana.Remove(3);
            }
        }

        private void quinta_CheckedChanged(object sender, EventArgs e)
        {
            if (quinta.Checked)
            {
                _diasSemana.Add(4);
            }
            else
            {
                _diasSemana.Remove(4);
            }
        }

        private void sexta_CheckedChanged(object sender, EventArgs e)
        {
            if (sexta.Checked)
            {
                _diasSemana.Add(5);
            }
            else
            {
                _diasSemana.Remove(5);
            }
        }

        private void sabado_CheckedChanged(object sender, EventArgs e)
        {
            if (sabado.Checked)
            {
                _diasSemana.Add(6);
            }
            else
            {
                _diasSemana.Remove(6);
            }
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                AdicionarDemanada();
                CarregarDemanda();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvDemanda.CurrentRow.Cells[0].Value.ToString());
                DemandaExtraCRUD.Delete(id);
                CarregarDemanda();
            }
            catch (Exception)
            {
                MessageBox.Show($"Não foi possível persistir os dados");
            }
        }

        private void CarregarDemanda()
        {
            try
            {
                dgvDemanda.DataSource = DemandaExtraCRUD.Get(p => p.Patrimonio.Equals(PatrimonioCRUD.Loaded.Id)).ToList();
                dgvDemanda.Columns[0].Visible = false;
                dgvDemanda.Columns[1].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show($"Não foi possível carregar os dados");
            }
        }
    }
}
