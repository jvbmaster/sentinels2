using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentinels2.Models
{
    internal class HoraExtra
    {
        public int EscalaOS { get; set; }
        public int Parte { get; set; }
        public DateTime Data { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public TimeSpan SimplesDiurna { get; set; }
        public TimeSpan SimplesNoturna { get; set; }
        public TimeSpan PlantaoDiurna { get; set; }
        public TimeSpan PlantaoNoturna { get; set; }
        public string Justificativa { get; set; }
    }
}
