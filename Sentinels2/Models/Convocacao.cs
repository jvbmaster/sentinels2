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
        public double SimplesDiaTotal { get; set; }
        public double SimplesNoiteTotal { get; set; }
        public double PlantaoDiaTotal { get; set; }
        public double PlantaoNoiteTotal { get; set; }

        public Convocacao()
        {
            HorasRealizadas = new List<HoraExtra>();
        }

        public void Totalizar()
        {
            SimplesDiaTotal     = HorasRealizadas.Sum(p => p.SimplesDiurna.TotalHours);
            SimplesNoiteTotal   = HorasRealizadas.Sum(p => p.SimplesNoturna.TotalHours);
            PlantaoDiaTotal     = HorasRealizadas.Sum(p => p.PlantaoDiurna.TotalHours);
            PlantaoNoiteTotal   = HorasRealizadas.Sum(p => p.PlantaoNoturna.TotalHours);
        }
    }
}
