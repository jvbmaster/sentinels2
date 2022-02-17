using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentinels2.Models
{
    internal class Convocacao
    {
        public Vigia Funcionario { get; set; }
        public DateTime DataDocumento { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public List<HoraExtra> HorasRealizadas { get; set; }
        public TimeSpan SimplesDiaTotal { get; set; }
        public TimeSpan SimplesNoiteTotal { get; set; }
        public TimeSpan PlantaoDiaTotal { get; set; }
        public TimeSpan PlantaoNoiteTotal { get; set; }

        public Convocacao()
        {
            HorasRealizadas = new List<HoraExtra>();
        }

        public void Totalizar()
        {
            foreach (var item in HorasRealizadas)
            {
                SimplesDiaTotal += item.SimplesDiurna;
                SimplesNoiteTotal += item.SimplesNoturna;
                PlantaoDiaTotal += item.PlantaoDiurna;
                PlantaoNoiteTotal += item.PlantaoNoturna;
            }
        }
    }
}
