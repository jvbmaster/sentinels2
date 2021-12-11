using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentinels2.Models
{
    internal class DemandaExtra
    {
        public int Id { get; set; }
        public string Patrimonio { get; set; }
        public int DiaSemana { get; set; }
        public TimeSpan Entrada { get; set; }
        public TimeSpan Saida { get; set; }
    }
}
