using Sentinels2.Models;

namespace Sentinels2.Rules
{
    internal class FechamentoHoraExtra : IDisposable
    {
        public Convocacao Convocacao { get; set; }

        public FechamentoHoraExtra(Vigia vigia, DateTime inicio, DateTime fim)
        {
            Convocacao = new Convocacao();
            Convocacao.Funcionario = vigia;
            Convocacao.DataDocumento = DateTime.Now;
            Convocacao.DataInicial = inicio;
            Convocacao.DataFinal = fim;
            
            Convocacao.SimplesDiaTotal = new TimeSpan(0, 0, 0);
            Convocacao.SimplesNoiteTotal = new TimeSpan(0, 0, 0);
            Convocacao.PlantaoDiaTotal = new TimeSpan(0, 0, 0);
            Convocacao.PlantaoNoiteTotal = new TimeSpan(0, 0, 0);
        }

        public void Analisar(Escala escala)
        {
            if(escala.Saida.Date > escala.Entrada.Date)
            {
                var parteA = new HoraExtra();
                parteA.Parte = 1;
                parteA.EscalaOS = escala.OS;
                parteA.Data = escala.Entrada.Date;
                parteA.Entrada = escala.Entrada;
                var auxDate = escala.Saida; // apenas para facilitar a manutencao do codigo
                parteA.Saida = new DateTime(auxDate.Year, auxDate.Month, auxDate.Day, 0, 0, 0);
                parteA.Justificativa = $"{escala.Motivo} em {escala.Patrimonio}";
                var auxA = Calcular(parteA);
                Convocacao.HorasRealizadas.Add(auxA);

                var parteB = new HoraExtra();
                parteB.Parte = 2;
                parteB.EscalaOS = escala.OS;
                parteB.Data = escala.Saida.Date;
                parteB.Entrada = parteA.Saida;
                parteB.Saida = escala.Saida;
                parteB.Justificativa = $"{escala.Motivo} em {escala.Patrimonio}";
                var auxB = Calcular(parteB);
                Convocacao.HorasRealizadas.Add(auxB);
            }
            else
            {
                var unica = new HoraExtra();
                unica.Parte = 0;
                unica.EscalaOS = escala.OS;
                unica.Data = escala.Data;
                unica.Entrada = escala.Entrada;
                unica.Saida = escala.Saida;
                unica.Justificativa = $"{escala.Motivo} em {escala.Patrimonio}";
                var auxU = Calcular(unica);
                Convocacao.HorasRealizadas.Add(auxU);
            }
        }

        private HoraExtra Calcular(HoraExtra extra)
        {
            DateTime horaNoturnaInicio = DateTime.Parse($"{extra.Data.ToString("yyyy-MM-dd")} 22:00:00");
            DateTime horaNoturnaFim = DateTime.Parse($"{extra.Data.ToString("yyyy-MM-dd")} 05:00:00");

            if (VerificarDiasEspeciais(extra) == true)
            {
                // horas 100 %
                switch (extra.Parte)
                {
                    case 0: // plantão diúrno
                        {
                            extra.PlantaoDiurna = (extra.Saida - extra.Entrada).Duration();
                            break;
                        }
                    case 1: // parte 1 de plantão noturno
                        {
                            extra.PlantaoDiurna = (horaNoturnaInicio - extra.Entrada).Duration();

                            if (extra.Entrada >= horaNoturnaInicio)
                            {
                                extra.PlantaoDiurna = new TimeSpan(0,0,0);
                                extra.PlantaoNoturna = (extra.Saida - extra.Entrada).Duration();
                            }
                            else
                            {
                                extra.PlantaoNoturna = (extra.Saida - horaNoturnaInicio).Duration();
                            }
                            break;
                        }
                    case 2: // parte 2 de plantão noturno
                        {
                            if(extra.Saida < horaNoturnaFim)
                            {
                                extra.PlantaoNoturna = (extra.Saida - extra.Entrada).Duration();
                                extra.PlantaoDiurna = new TimeSpan(0,0,0);

                            }
                            else
                            {
                                extra.PlantaoNoturna = (horaNoturnaFim - extra.Entrada).Duration();
                                extra.PlantaoDiurna = (extra.Saida - horaNoturnaFim).Duration();
                            }
                            break;
                        }
                }
            }
            else 
            {
                // horas 50 %
                switch (extra.Parte)
                {
                    case 0: // plantão diúrno
                        {
                            extra.SimplesDiurna = (extra.Saida - extra.Entrada).Duration();
                            break;
                        }
                    case 1: // parte 1 de plantão noturno
                        {
                            extra.SimplesDiurna = (horaNoturnaInicio - extra.Entrada).Duration();

                            if (extra.Entrada >= horaNoturnaInicio)
                            {
                                extra.SimplesDiurna = new TimeSpan(0,0,0);
                                extra.SimplesNoturna = (extra.Saida - extra.Entrada);
                            }
                            else
                            {
                                extra.SimplesNoturna = (extra.Saida - horaNoturnaInicio).Duration();
                            }
                            break;
                        }
                    case 2: // parte 2 de plantão noturno
                        {
                            if (extra.Saida < horaNoturnaFim)
                            {
                                extra.SimplesNoturna = (extra.Saida - extra.Entrada).Duration();
                                extra.SimplesDiurna = new TimeSpan(0,0,0);
                            }
                            else
                            {
                                extra.SimplesNoturna = (horaNoturnaFim - extra.Entrada).Duration();
                                extra.SimplesDiurna = (extra.Saida - horaNoturnaFim).Duration();
                            }
                            break;
                        }
                }
            }
            return extra;
        }

        private bool VerificarDiasEspeciais(HoraExtra extra)
        {
            if((extra.Data.DayOfWeek == DayOfWeek.Saturday) || (extra.Data.DayOfWeek == DayOfWeek.Sunday))
            {
                return true;
            }
            return false;
        }

        public void Dispose()
        {
           // GC.SuppressFinalize(this);
        }
            
    }
}
