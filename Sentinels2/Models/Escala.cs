using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentinels2.Models
{
    internal class Escala
    {
        public int OS { get; set; }
        public string Patrimonio { get; set; }
        public DateTime Data { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public string Vigia { get; set; }
        public string Motivo { get; set; }
        public string TipoPagamento { get; set; }
        public double Duracao { get; set; }
    }
}
