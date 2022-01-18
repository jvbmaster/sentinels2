using Sentinels2.Data;
using Sentinels2.Models;

namespace Sentinels2.Views
{
    public partial class SetPatrimonio : Form
    {
        private List<Horario> _horarios = new List<Horario>();
        private List<Patrimonio> _patrimonios = new List<Patrimonio>();

        public SetPatrimonio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SetPatrimonio_Load(object sender, EventArgs e)
        {
            opHFixos.Checked = true;
            CarregarPatrimonio();
        }

        private void CarregarPatrimonio(string pesquisa = "")
        {
            try
            {
                _patrimonios = (pesquisa.Equals("")) ? PatrimonioCRUD.GetAll().ToList() : PatrimonioCRUD.Get(p => p.Titulo.Contains(pesquisa)).ToList();

                dgvPatrimonios.DataSource = _patrimonios;
                dgvPatrimonios.Columns[0].Visible = false;
                dgvPatrimonios.Columns[2].Visible = false;
                dgvPatrimonios.Columns[3].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar os Patrimônios");
            }
        }

        private void fSearch_TextChanged(object sender, EventArgs e)
        {
            CarregarPatrimonio(fSearch.Text);
        }

        private void dgvPatrimonios_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void CarregarHorarios(string idPAtrimonio)
        {
            try
            {
                _horarios = new List<Horario>();

                Patrimonio p = PatrimonioCRUD.Find(idPAtrimonio);

                DateTime referencia = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, p.HoraReferencia.Hours, p.HoraReferencia.Minutes, 0);
                DateTime aux = new DateTime();
                aux = (p.TipoVigilancia == 24) ? referencia.AddHours(12) : referencia.AddHours(p.TipoVigilancia);
                
                Horario h = new Horario();
                h.Entrada = TimeSpan.Parse(referencia.ToShortTimeString());
                h.Saida = TimeSpan.Parse(aux.ToShortTimeString());

                _horarios.Add(h);

                if(p.TipoVigilancia == 24)
                {
                    Horario j = new Horario();
                    j.Entrada = h.Saida;
                    j.Saida = TimeSpan.Parse(aux.AddHours(12).ToShortTimeString());
                    _horarios.Add(j);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível adicionar os horários desse patrimônio\n{ex}");
            }
        }
        private void AnexarHorario(string idPatrimonio, TimeSpan entrada, TimeSpan saida)
        {
            try
            {
                PatrimonioCRUD.Load(idPatrimonio);
                Horario.entrada = entrada;
                Horario.saida = saida;
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível selecionar o Patrimônio");
            }
        }

        private void CarregarDemandaExtra()
        {
            try
            {
                dgvDemandaExtra.DataSource = DemandaExtraCRUD.Get(p => p.Patrimonio.Equals(dgvPatrimonios.CurrentRow.Cells[0].Value.ToString()))
                    .Select(p => new {
                        p.Patrimonio,
                        Dia = p.DiaSemana,
                        p.Entrada,
                        Saída = p.Saida
                    })
                    .ToList();
                dgvDemandaExtra.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                statusLabel.Text = $"DEMANDA_EXTRA: {ex.Message}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string patrimonio = dgvPatrimonios.CurrentRow.Cells[0].Value.ToString();
            TimeSpan entrada = (opHFixos.Checked == true)
                                ? TimeSpan.Parse(dgvHorarios.CurrentRow.Cells[0].Value.ToString())
                                : TimeSpan.Parse(dgvDemandaExtra.CurrentRow.Cells[2].Value.ToString());
            TimeSpan saida = (opHFixos.Checked == true)
                                ? TimeSpan.Parse(dgvHorarios.CurrentRow.Cells[1].Value.ToString())
                                : TimeSpan.Parse(dgvDemandaExtra.CurrentRow.Cells[3].Value.ToString());
            AnexarHorario(patrimonio, entrada, saida);
        }

        private void dgvPatrimonios_MouseClick(object sender, MouseEventArgs e)
        {
            CarregarHorarios(dgvPatrimonios.CurrentRow.Cells[0].Value.ToString());
            dgvHorarios.DataSource = _horarios;
            CarregarDemandaExtra();
        }

        private void btSetAll_Click(object sender, EventArgs e)
        {
            foreach (var p in _patrimonios)
            {
                CarregarHorarios(p.Id);

                foreach (var h in _horarios)
                {
                    AnexarHorario(p.Id, h.Entrada, h.Saida);

                    using (PatrimonioHorario ph = new PatrimonioHorario())
                    {
                        ph.PatrimonioId = p.Id;
                        ph.Entrada = Horario.entrada;
                        ph.Saida = Horario.saida;
                        ph.Duracao = PatrimonioCRUD.Loaded.TipoVigilancia;
                        ph.Motivo = PatrimonioCRUD.Loaded.DescricaoVigilancia;

                        GerarEscalas(ph);
                    }
                }
            }
        }

        private void GerarEscalas(PatrimonioHorario ph)
        {
            foreach (var d in DateCheck.Dates)
            {
                if (d.Checked == true)
                {
                    using (Escala es = new Escala())
                    {
                        es.Patrimonio = ph.PatrimonioId;
                        es.Data = new DateTime(d.Date.Year, d.Date.Month, d.Date.Day);
                        es.Entrada = new DateTime(d.Date.Year, d.Date.Month, d.Date.Day, ph.Entrada.Hours, ph.Entrada.Minutes, 0);
                        es.Saida = es.Entrada.AddHours((ph.Duracao == 24) ? 12 : ph.Duracao);
                        es.TipoPagamento = "";
                        es.Motivo = ph.Motivo;
                        es.Duracao = (ph.Duracao == 24) ? 12 : ph.Duracao;
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

        private void btAddDemandaExtra_Click(object sender, EventArgs e)
        {
            try
            {
                if(new AddHorarioExtra().ShowDialog() == DialogResult.OK)
                {
                    DemandaExtraCRUD.ObjectInstanceate.Patrimonio = dgvPatrimonios.CurrentRow.Cells[0].Value.ToString();
                    DemandaExtraCRUD.Insert(DemandaExtraCRUD.ObjectInstanceate);
                    CarregarDemandaExtra();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível adicionar os novos horários para o patrimônio\nErro: {ex.Message}");
            }
        }

        private void opHFixos_CheckedChanged(object sender, EventArgs e)
        {
            dgvDemandaExtra.Enabled = false;
        }

        private void opHExtra_CheckedChanged(object sender, EventArgs e)
        {
            dgvDemandaExtra.Enabled = true;
        }
    }
}
