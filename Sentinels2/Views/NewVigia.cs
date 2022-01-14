using Sentinels2.Data;
using Sentinels2.Models;

namespace Sentinels2.Views
{
    public partial class NewVigia : Form
    {
        public NewVigia()
        {
            InitializeComponent();
        }

        private int mode = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            Vigia vigia = new Vigia {
                Id = fId.Text.ToUpper(),
                Nome = fNome.Text.ToUpper(),
                Cargo = fCargo.Text,
                RG = fRG.Text.ToUpper(),
                CPF = fCPF.Text.ToUpper(),
                Lotacao = fLotacao.Text,
                Nascimento = DateTime.Parse(fNascimento.Text),
                Admissao = DateTime.Parse(fAdmissao.Text),
                Matricula = fMatricula.Text.ToUpper(),
                Telefone = (fTelefone.Text != "") ? fTelefone.Text : fTelefone2.Text,
                Endereco = $"{fLogradouro.Text}, {fNumero.Text} - {fBairro.Text} - {fMunicipio.Text}/{fUF.Text} CEP: {fCEP.Text}",
                RH = ""
            };
            try
            {
                if(mode == 0)
                {
                    VigiaCRUD.Insert(vigia);
                    MessageBox.Show("Novo membro cadastrado com sucesso!");
                }
                else
                {
                    VigiaCRUD.Update(vigia);
                    MessageBox.Show("Dados atualizados com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao gravar dados\n{ex.Message}");
            }
        }

        private void NewVigia_Load(object sender, EventArgs e)
        {
            if(VigiaCRUD.Loaded != null)
            {
                mode = 1;
                fNome.Text = VigiaCRUD.Loaded.Nome;
                fId.Text = VigiaCRUD.Loaded.Id;
                fMatricula.Text = VigiaCRUD.Loaded.Matricula;
                fAdmissao.Text = VigiaCRUD.Loaded.Admissao.ToString("dd/MM/yyyy");
                fNascimento.Text = VigiaCRUD.Loaded.Nascimento.ToString("dd/MM/yyyy");
                fTelefone.Text = VigiaCRUD.Loaded?.Telefone;
                fCargo.Text = VigiaCRUD.Loaded.Cargo;
                fLotacao.Text = VigiaCRUD.Loaded.Lotacao;
                fCPF.Text = VigiaCRUD.Loaded.CPF;
                fRG.Text = VigiaCRUD.Loaded.RG;
                lbEndereco.MaximumSize = new Size(370, 0);
                lbEndereco.AutoSize = true;
                lbEndereco.Text = VigiaCRUD.Loaded.Endereco;
            }
        }
    }
}
