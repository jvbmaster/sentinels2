using Sentinels2.Data;
using Sentinels2.Models;

namespace Sentinels2.Views
{
    public partial class AddPatrimonio : Form
    {
        private bool editMode = false;
        public AddPatrimonio()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Patrimonio patrimonio = new Patrimonio();
                patrimonio.Id = fID.Text.ToUpper();
                patrimonio.Titulo = fTitulo.Text.ToUpper();
                patrimonio.TipoVigilancia = int.Parse(fDuracao.Value.ToString());
                patrimonio.DescricaoVigilancia = (patrimonio.TipoVigilancia == 24) ? "Vigilância Ininterrupta" : "Vigilância em Horário de Risco";
               
                switch(editMode)
                {
                    case true:
                        {
                            patrimonio.HoraReferencia = TimeSpan.Parse(fHoraReferencia.Text);
                            PatrimonioCRUD.Update(patrimonio);
                            PatrimonioCRUD.ObjectInstanceate = null;
                            break;
                        }
                    case false:
                        {
                            PatrimonioCRUD.Insert(patrimonio); break;
                        }
                }
                
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível cadastrar o patrimônio\nERRO: {ex}");
                DialogResult = DialogResult.Cancel;
            }
        }

        private void fDuracao_Leave(object sender, EventArgs e)
        {
            lbDefinicaoTIpo.Text = (fDuracao.Value == 24) ? "Vigilância Ininterrupta" : "Vigilância em Horário de Risco";
        }

        private void AddPatrimonio_Load(object sender, EventArgs e)
        {
            if(PatrimonioCRUD.ObjectInstanceate != null)
            {
                editMode = true;
                fID.Text = PatrimonioCRUD.ObjectInstanceate.Id;
                fID.Enabled = false;
                fTitulo.Text = PatrimonioCRUD.ObjectInstanceate.Titulo;
                fDuracao.Value = PatrimonioCRUD.ObjectInstanceate.TipoVigilancia;
                fHoraReferencia.Text = PatrimonioCRUD.ObjectInstanceate.HoraReferencia.ToString();
                lbDefinicaoTIpo.Text = PatrimonioCRUD.ObjectInstanceate.DescricaoVigilancia;
            }
        }
    }
}
