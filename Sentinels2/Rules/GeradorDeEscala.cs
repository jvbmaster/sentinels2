using Sentinels2.Data;
using Sentinels2.Models;

namespace Sentinels2.Rules
{
    internal class GeradorDeEscala
    {
        private List<Horario> _horarios = new List<Horario>();
        private List<Patrimonio> _patrimonios = PatrimonioCRUD.GetAll().ToList();

        public void Execute()
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
            MessageBox.Show("Escala Completa");
        }

        public void CarregarHorarios(string idPAtrimonio)
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

                if (p.TipoVigilancia == 24)
                {
                    Horario j = new Horario();
                    j.Entrada = h.Saida;
                    j.Saida = TimeSpan.Parse(aux.AddHours(12).ToShortTimeString());
                    _horarios.Add(j);
                }

            }
            catch (Exception)
            {
                MessageBox.Show($"Não foi possível definir os horários para este patrimônio");
            }
        }

        public void AnexarHorario(string idPatrimonio, TimeSpan entrada, TimeSpan saida)
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

        public void GerarEscalas(PatrimonioHorario ph)
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
                        es.Duracao = (es.Saida - es.Entrada).Duration();
                        es.Vigia = "";
                        es.AfastamentoVGF = 0;
                        try
                        {
                            EscalaCRUD.Insert(es);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show($"Não foi possível persistir os dados da escala atual");
                            return;
                        }
                    }
                }
            }
        }

    }
}
