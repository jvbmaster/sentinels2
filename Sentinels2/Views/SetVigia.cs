using System.Data;
using Sentinels2.Data;
using Sentinels2.Models;
using Sentinels2.Rules;

namespace Sentinels2.Views
{
    public partial class SetVigia : Form
    {
        private string tipoAfastamento;
        public SetVigia()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BuscarVigias(textBox1.Text);
        }

        private void BuscarVigias(string busca = "")
        {
            try
            {
                var data = (busca == "") 
                    ? VigiaCRUD.GetAll().ToList() :
                    VigiaCRUD.Get(p => p.Nome.Contains(busca)).ToList();

                dataGridView1.DataSource = data.Select(p => new {
                    p.Id,
                    p.Nome,
                    p.Cargo,
                    p.Lotacao
                }).ToList();
                dataGridView1.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private void SetVigia_Load(object sender, EventArgs e)
        {
            BuscarVigias();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string vgm = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                int verificaAbono = AfastamentoCRUD.Get(p => p.Funcionario.Equals(vgm) && p.TipoAfastamento.Equals(tipoAfastamento) && p.DataInicial.Year.Equals(DateTime.Now.Year)).Count();
                
                if(verificaAbono > 5)
                {
                    MessageBox.Show("Funcionário não tem direiro a abonar novas faltas!");
                    return;
                }

                string referencia = $"{DateTime.Now.Year}/{verificaAbono + 1}";

                AfastamentoCRUD.ObjectInstanceate.Funcionario = vgm;
                AfastamentoCRUD.ObjectInstanceate.Referencia = (tipoAfastamento == "Abono") ? referencia : fRef.Text;
                AfastamentoCRUD.ObjectInstanceate.TipoAfastamento = tipoAfastamento;
                //AfastamentoCRUD.ObjectInstanceate.QuantidadeDias = DateCheck.Dates.Count;
                //AfastamentoCRUD.ObjectInstanceate.DataInicial = DateCheck.Dates[0].Date;
                //AfastamentoCRUD.ObjectInstanceate.DataFinal = DateCheck.Dates[DateCheck.Dates.Count-1].Date;
                AfastamentoCRUD.Insert(AfastamentoCRUD.ObjectInstanceate);
                if(MessageBox.Show($"{tipoAfastamento} registrado com sucesso! Deseja imprimir agora?", "Çool", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Relatorios report = new Relatorios();

                    switch (tipoAfastamento)
                    {
                        case "Abono": report.GerarAbonada(AfastamentoCRUD.ObjectInstanceate); break;
                        case "Férias": report.GerarFerias(AfastamentoCRUD.ObjectInstanceate); break;
                    }
                }



                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private void GerarAquivoParaImpressao()
        {
            
        }

        
    }
}
