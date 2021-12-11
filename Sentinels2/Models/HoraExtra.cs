using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentinels2.Models
{
    internal class HoraExtra
    {
        public string Parte { get; set; }
        public bool IsPlantao { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Entrada { get; set; }
        public TimeSpan Saida { get; set; }
        public double HSimplesDia { get; set; }
        public double HSimplesNoite { get; set; }
        public double HPlantaoDia { get; set; }
        public double HPlantaoNoite { get; set; }
        public string Justificativa { get; set; }
    }
}
