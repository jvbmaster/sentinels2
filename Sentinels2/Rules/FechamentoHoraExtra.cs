using Sentinels2.Models;

namespace Sentinels2.Rules
{
    internal class FechamentoHoraExtra : IDisposable
    {
        public Convocacao convocacao { get; set; }

        public FechamentoHoraExtra(Vigia vigia, DateTime inicio, DateTime fim)
        {
            convocacao = new Convocacao();
            convocacao.Funcionario = vigia;
            convocacao.DataDocumento = DateTime.Now;
            convocacao.DataInicial = inicio;
            convocacao.DataFinal = fim;
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
                convocacao.HorasRealizadas.Add(Calcular(parteA));

                // test
               // MessageBox.Show($"{parteA.Parte} - {parteA.EscalaOS} {parteA.Entrada} {parteA.Saida}");

                var parteB = new HoraExtra();
                parteB.Parte = 2;
                parteB.EscalaOS = escala.OS;
                parteB.Data = escala.Saida.Date;
                parteB.Entrada = parteA.Saida;
                parteB.Saida = escala.Saida;
                parteB.Justificativa = $"{escala.Motivo} em {escala.Patrimonio}";
                convocacao.HorasRealizadas.Add(Calcular(parteB));

                //test
               // MessageBox.Show($"{parteB.Parte} - {parteB.EscalaOS} {parteB.Entrada} {parteB.Saida}");

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
                convocacao.HorasRealizadas.Add(Calcular(unica));

                //MessageBox.Show($"{unica.Parte} - {unica.EscalaOS} {unica.Entrada} {unica.Saida}");

            }
        }

        private HoraExtra Calcular(HoraExtra extra)
        {
            DateTime horaNoturnaInicio = DateTime.Parse($"{extra.Data.ToString("yyyy-MM-dd")} 22:00:00");
            DateTime horaNoturnaFim = DateTime.Parse($"{extra.Data.ToString("yyyy-MM-dd")} 05:00:00");

            if (VerificarDiasEspeciais(extra) == true)
            {
                switch (extra.Parte)
                {
                    case 0:
                        {
                            extra.PlantaoDiurna = (extra.Saida - extra.Entrada).Duration();
                            break;
                        }
                    case 1:
                        {
                            // não suporta entrada posterior ao ínicio do horário noturno e saida antes do fim do horário noturno
                            extra.PlantaoDiurna = (horaNoturnaInicio - extra.Entrada).Duration();
                            extra.PlantaoNoturna = (extra.Saida - horaNoturnaInicio).Duration();
                            break;
                        }
                    case 2:
                        {
                            // não suporta entrada posterior ao ínicio do horário noturno e saida antes do fim do horário noturno
                            extra.PlantaoNoturna = (horaNoturnaFim - extra.Entrada).Duration();
                            extra.PlantaoDiurna = (extra.Saida - horaNoturnaFim).Duration();
                            break;
                        }
                }
            }
            else
            {
                switch (extra.Parte)
                {
                    case 0:
                        {
                            extra.SimplesDiurna = (extra.Saida - extra.Entrada).Duration();
                            break;
                        }
                    case 1:
                        {
                            // não suporta entrada posterior ao ínicio do horário noturno e saida antes do fim do horário noturno
                            extra.SimplesDiurna = (horaNoturnaInicio - extra.Entrada).Duration();
                            extra.SimplesNoturna = (extra.Saida - horaNoturnaInicio).Duration();
                            break;
                        }
                    case 2:
                        {
                            // não suporta entrada posterior ao ínicio do horário noturno e saida antes do fim do horário noturno
                            extra.SimplesNoturna = (horaNoturnaFim - extra.Entrada).Duration();
                            extra.SimplesDiurna = (extra.Saida - horaNoturnaFim).Duration();
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
