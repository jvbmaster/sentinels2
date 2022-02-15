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
    public partial class EditEscala : Form
    {
        public EditEscala()
        {
            InitializeComponent();
        }

        private void EditEscala_Load(object sender, EventArgs e)
        {
            if(EscalaCRUD.ObjectInstanceate != null)
            {
                Escala escala = EscalaCRUD.ObjectInstanceate;
                fOS.Text = escala.OS.ToString();
                fPatrimonio.Text = escala.Patrimonio;
                fData.Text = escala.Data.ToString();
                fEntrada.Text = escala.Entrada.ToString();
                fSaida.Text = escala.Saida.ToString();
                fMotivo.Text = escala.Motivo;
                fTipoPagamento.Text = escala.TipoPagamento;
                fVigia.Text = escala.Vigia;
                fAfastamento.Text = escala.AfastamentoVGF.ToString();
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            DateTime entrada, saida;



            EscalaCRUD.ObjectInstanceate.Patrimonio = fPatrimonio.Text; // = escala.Patrimonio;
            EscalaCRUD.ObjectInstanceate.Data = DateTime.Parse(fData.Text); // = escala.Data.ToString("dd/MM/yyyy");
            EscalaCRUD.ObjectInstanceate.Entrada = DateTime.Parse(fEntrada.Text); // = escala.Entrada.ToString("HH:mm");
            EscalaCRUD.ObjectInstanceate.Saida = DateTime.Parse(fSaida.Text); // = escala.Saida.ToString("HH:mm");
            EscalaCRUD.ObjectInstanceate.Motivo = fMotivo.Text; // = escala.Motivo;
            EscalaCRUD.ObjectInstanceate.TipoPagamento = fTipoPagamento.Text; // = escala.TipoPagamento;
            EscalaCRUD.ObjectInstanceate.Vigia = fVigia.Text; // = escala.Vigia;
            EscalaCRUD.ObjectInstanceate.AfastamentoVGF = int.Parse(fAfastamento.Text); // = escala.AfastamentoVGF.ToString();

            try
            {
                EscalaCRUD.Update(EscalaCRUD.ObjectInstanceate);
                Close();
            }
            catch (Exception)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
