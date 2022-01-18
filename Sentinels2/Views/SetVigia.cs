using System.Data;
using Sentinels2.Data;
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
                string referencia = "";

                int verificaAbono = 0;
                if (tipoAfastamento == "Abono")
                {
                    verificaAbono = AfastamentoCRUD.Get(p => p.Funcionario.Equals(vgm) && p.TipoAfastamento.Equals(tipoAfastamento) && p.DataInicial.Year.Equals(DateTime.Now.Year)).Count();
                    
                    if(verificaAbono > 5)
                    {
                        MessageBox.Show("Funcionário não tem direiro a abonar novas faltas!");
                        return;
                    }
                    referencia = $"{DateTime.Now.Year}/{verificaAbono + 1}";
                }

                AfastamentoCRUD.ObjectInstanceate.Funcionario = vgm;
                AfastamentoCRUD.ObjectInstanceate.Referencia = (tipoAfastamento == "Abono") ? referencia : fRef.Text;
                AfastamentoCRUD.ObjectInstanceate.TipoAfastamento = tipoAfastamento;
                AfastamentoCRUD.Insert(AfastamentoCRUD.ObjectInstanceate);

                // Selecionando último afastamento registrado
                AfastamentoCRUD.ObjectInstanceate = AfastamentoCRUD.GetAll().OrderBy(x => x.Id).Last();

                //MessageBox.Show($"Afastamento ID: {AfastamentoCRUD.ObjectInstanceate.Id} de {AfastamentoCRUD.ObjectInstanceate.Funcionario}");

                // Adicionando Id de Afastamento nas datas onde o VGM está escalado
                var buscaescala = EscalaCRUD.Get(p => p.Vigia.Equals(vgm) &&
                                 (p.Data >= AfastamentoCRUD.ObjectInstanceate.DataInicial &&
                                 p.Data <= AfastamentoCRUD.ObjectInstanceate.DataFinal)).ToList();

                foreach (var item in buscaescala)
                {
                    item.AfastamentoVGF = AfastamentoCRUD.ObjectInstanceate.Id;
                    EscalaCRUD.Update(item);
                }

                // Gerar Documento
                if(MessageBox.Show($"{tipoAfastamento} registrado com sucesso! Deseja imprimir agora?", "Çool", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Relatorios report = new Relatorios();

                    switch (tipoAfastamento)
                    {
                        case "Abono": report.GerarAbonada(AfastamentoCRUD.ObjectInstanceate); break;
                        case "Férias": report.GerarFerias(AfastamentoCRUD.ObjectInstanceate); break;
                        case "Licença Prêmio": report.GerarLicencaPremio(AfastamentoCRUD.ObjectInstanceate); break;
                        case "Licença Saúde": report.GerarLicencaMedica(AfastamentoCRUD.ObjectInstanceate); break;
                        case "Casamento": report.GerarAfastamento(AfastamentoCRUD.ObjectInstanceate); break;
                        case "Doação de Sanguê": report.GerarAfastamento(AfastamentoCRUD.ObjectInstanceate); break;
                        case "Paternidade": report.GerarAfastamento(AfastamentoCRUD.ObjectInstanceate); break;
                        case "Luto": report.GerarAfastamento(AfastamentoCRUD.ObjectInstanceate); break;
                        case "TRE": report.GerarAfastamento(AfastamentoCRUD.ObjectInstanceate); break;
                        case "Outros": report.GerarAfastamento(AfastamentoCRUD.ObjectInstanceate); break;
                    }
                }

                DialogResult = DialogResult.Yes;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

    }
}
