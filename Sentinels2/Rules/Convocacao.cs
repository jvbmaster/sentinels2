using Sentinels2.Models;

namespace Sentinels2.Rules
{
    internal class Convocacao
    {
        public List<HoraExtra> ListaDeHoras { get; set; }
        public double HSimplesDiaTotal { get; set; }
        public double HSimplesNoiteTotal { get; set; }
        public double HPlantaoDiaTotal { get; set; }
        public double HPlantaoNoiteTotal { get; set; }

        public void Analisar(Escala escala)
        {
            if(escala.Saida.Day > escala.Entrada.Day)
            {
                HoraExtra parteA = new HoraExtra();
                HoraExtra parteB = new HoraExtra();

                parteA.Parte = "A";
                parteA.Data = escala.Data;
                parteA.Entrada = TimeSpan.Parse(escala.Entrada.ToShortTimeString());
                parteA.Saida = new TimeSpan(0, 0, 0);
                parteA.Justificativa = escala.Motivo;

                parteB = parteA;
                parteB.Parte = "B";
                parteB.Data.AddDays(1);
                parteB.Entrada = new TimeSpan(0,0,0);

                SepararHoras(parteA);
                SepararHoras(parteB);

                ListaDeHoras.Add(parteA);
                ListaDeHoras.Add(parteB);
            }
            else
            {
                HoraExtra parteUnica = new HoraExtra();
                parteUnica.Parte = "U";
                parteUnica.Data = escala.Data;
                parteUnica.Entrada = TimeSpan.Parse(escala.Entrada.ToShortTimeString());
                parteUnica.Saida = TimeSpan.Parse(escala.Saida.ToShortTimeString());
                parteUnica.Justificativa = escala.Motivo;
                SepararHoras(parteUnica);
                ListaDeHoras.Add(parteUnica);
            }
        }

        public void Totalizar()
        {
            foreach (var item in ListaDeHoras)
            {
                HSimplesDiaTotal += item.HSimplesDia;
                HSimplesNoiteTotal += item.HSimplesNoite;
                HPlantaoDiaTotal += item.HPlantaoDia;
                HPlantaoNoiteTotal += item.HPlantaoNoite;
            }
        }

        // Verifica se a data no banco de dados consta na tabela de feriados
        public bool TiparHora(DateTime data)
        {
            return (data != null) ? true : false;
        }

        private double CalcularDuracao(TimeSpan Entrada, TimeSpan Saida) => (Saida - Entrada).TotalHours;

        public int SepararHoras(HoraExtra extra)
        {
            switch(extra.Parte)
            {
                case "A":
                    {
                        TimeSpan noiteInicio = new TimeSpan(22,0,0);
                        if (TiparHora(extra.Data)) // Se 100%
                        {
                            if(extra.Entrada < noiteInicio)
                            {
                                extra.HPlantaoDia = CalcularDuracao(extra.Entrada, noiteInicio);
                                extra.HPlantaoNoite = CalcularDuracao(noiteInicio, extra.Saida);
                            }
                            else
                            {
                                extra.HPlantaoDia = 0;
                                extra.HPlantaoNoite = CalcularDuracao(extra.Entrada, extra.Saida);
                            }
                        }
                        else // Se 50%
                        {
                            if (extra.Entrada < noiteInicio)
                            {
                                extra.HSimplesDia = CalcularDuracao(extra.Entrada, noiteInicio);
                                extra.HSimplesNoite = CalcularDuracao(noiteInicio, extra.Saida);
                            }
                            else
                            {
                                extra.HSimplesDia = 0;
                                extra.HSimplesNoite = CalcularDuracao(extra.Entrada, extra.Saida);
                            }
                        }
                        break;
                    }
                    case "B":
                    {
                        TimeSpan noiteFim = new TimeSpan(5,0,0);
                        if (TiparHora(extra.Data)) // Se 100%
                        {
                            if(extra.Saida > noiteFim)
                            {
                                extra.HPlantaoNoite = CalcularDuracao(extra.Entrada, noiteFim);
                                extra.HPlantaoDia = CalcularDuracao(noiteFim, extra.Saida);
                            }
                            else
                            {
                                extra.HPlantaoNoite = CalcularDuracao(extra.Entrada, extra.Saida);
                                extra.HPlantaoDia = 0;
                            }
                        }
                        else // Se 50%
                        {
                            if (extra.Saida > noiteFim)
                            {
                                extra.HSimplesNoite = CalcularDuracao(extra.Entrada, noiteFim);
                                extra.HSimplesDia = CalcularDuracao(noiteFim, extra.Saida);
                            }
                            else
                            {
                                extra.HSimplesNoite = CalcularDuracao(extra.Entrada, extra.Saida);
                                extra.HSimplesDia = 0;
                            }
                        }
                        break;
                    }
                    case "U":
                    {
                        TimeSpan noiteInicio = new TimeSpan(22,0,0);
                        if(TiparHora(extra.Data)) // Se 100%
                        {
                            if (extra.Saida > noiteInicio)
                            {
                                extra.HPlantaoDia = CalcularDuracao(extra.Entrada, noiteInicio);
                                extra.HPlantaoNoite = CalcularDuracao(noiteInicio, extra.Saida);
                            }
                            else
                            {
                                extra.HPlantaoDia = CalcularDuracao(extra.Entrada, extra.Saida);
                                extra.HPlantaoNoite = 0;
                            }
                        }
                        else // Se 50%
                        {
                            if (extra.Saida > noiteInicio)
                            {
                                extra.HSimplesDia = CalcularDuracao(extra.Entrada, noiteInicio);
                                extra.HSimplesNoite = CalcularDuracao(noiteInicio, extra.Saida);
                            }
                            else
                            {
                                extra.HSimplesDia = CalcularDuracao(extra.Entrada, extra.Saida);
                                extra.HSimplesNoite = 0;
                            }
                        }
                        break;
                    }
            }
            return 0;
        }
    }
}
