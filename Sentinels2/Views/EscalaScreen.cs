using System.Globalization;
using System.Linq;
using Sentinels2.Data;
using Sentinels2.Models;
using Sentinels2.Rules;

namespace Sentinels2.Views
{
    public partial class EscalaScreen : Form
    {
        private List<PatrimonioHorario> _patrimonios = new List<PatrimonioHorario>();
        public EscalaScreen()
        {
            InitializeComponent();
        }

        private void EscalaScreen_Load(object sender, EventArgs e)
        {
            int l = DateCheck.Dates.Count;
            CheckBox i;
            checkedListBox1.Text = (l > 1) ? $"{l} dias adicionados" : $"{l} dia adicionado";
            DateCheck auxDateCheck;
            int index;
            
            panel1.Controls.Clear();

            foreach (var item in DateCheck.Dates)
            {
                i = new CheckBox();
                i.Checked = item.Checked;
                i.Text = $"{item.Date.ToString("dd/MM/yyyy")} ({item.Date.ToString("dddd", new CultureInfo("pt-BR"))})";
                panel1.Controls.Add(i);
                i.Dock = DockStyle.Bottom;
                i.CheckedChanged += (object? sender, EventArgs e) => {
                    item.Checked = (item.Checked == true) ? false : true;
                };
            }
        }

        // Marcar ou desmarcar todas as Datas
        public void DesmarcarDatas(bool check = false)
        {
            foreach (CheckBox item in panel1.Controls)
            {
                item.Checked = check;
            }
        }
        // Marcar pares
        private void button1_Click(object sender, EventArgs e)
        {
            DesmarcarDatas();
            bool previous = (DateCheck.Dates.ElementAt(0).Date.Day % 2 == 0) ? true : false;
            foreach (CheckBox item  in panel1.Controls)
            {
                item.Checked = previous;
                previous = !previous;
            }
        }
        //Marcar Ímpares
        private void button2_Click(object sender, EventArgs e)
        {
            DesmarcarDatas();
            bool previous = (DateCheck.Dates.ElementAt(0).Date.Day % 2 != 0) ? true : false;
            foreach (CheckBox item in panel1.Controls)
            {
                item.Checked = previous;
                previous = !previous;
            }
        }
        // Desmarcar todas
        private void button4_Click(object sender, EventArgs e)
        {
            DesmarcarDatas();
        }
        // Marcar todas
        private void button3_Click(object sender, EventArgs e)
        {
            DesmarcarDatas(true);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(new SetPatrimonio().ShowDialog() == DialogResult.Yes)
            {
                using (PatrimonioHorario ph = new PatrimonioHorario())
                {
                    ph.PatrimonioId = PatrimonioCRUD.Loaded.Id;
                    ph.Entrada = Horario.entrada;
                    ph.Saida = Horario.saida;
                    ph.Duracao = PatrimonioCRUD.Loaded.TipoVigilancia;
                    ph.Motivo = PatrimonioCRUD.Loaded.DescricaoVigilancia;
                    _patrimonios.Add(ph);
                }
            }

            dgvPatrimonios.ColumnCount = 3;
            dgvPatrimonios.Columns[0].Name = "Local";
            dgvPatrimonios.Columns[1].Name = "Entrada";
            dgvPatrimonios.Columns[2].Name = "Saída";

            foreach (var item in _patrimonios)
            {
                dgvPatrimonios.RowCount = _patrimonios.Count-1;
                object[] row = new object[] { item.PatrimonioId, item.Entrada, item.Saida };
                dgvPatrimonios.Rows.Add(row);
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            foreach (var p in _patrimonios)
            {
                foreach (var d in DateCheck.Dates)
                {
                    if(d.Checked == true)
                    {
                        using (Escala es = new Escala())
                        {
                            es.Patrimonio = p.PatrimonioId;
                            es.Data = new DateTime(d.Date.Year, d.Date.Month, d.Date.Day);
                            es.Entrada = new DateTime(d.Date.Year, d.Date.Month, d.Date.Day, p.Entrada.Hours, p.Entrada.Minutes, 0);
                            es.Saida = es.Entrada.AddHours((p.Duracao == 24) ? 12 : p.Duracao);
                            es.TipoPagamento = "";
                            es.Motivo = p.Motivo;
                            es.Duracao = (p.Duracao == 24) ? 12 : p.Duracao;
                            es.Vigia = "";
                            es.AfastamentoVGF = 0;
                            try
                            {
                                EscalaCRUD.Insert(es);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"{ex}");
                                return;
                            }
                        }
                    }
                }
            }
            MessageBox.Show("Cool");
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adicionar Novo Motivo");
        }

        private void btAddAll_Click(object sender, EventArgs e)
        {
            
        }

        private void btAddAll_Click_1(object sender, EventArgs e)
        {
            new GeradorDeEscala().Execute();
        }
    }
}
