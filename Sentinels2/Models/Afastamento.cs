using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentinels2.Models
{
    internal class Afastamento
    {
        public int Id { get; set; }
        public string Funcionario { get; set; }
        public string TipoAfastamento { get; set; }
        public int QuantidadeDias { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public string Referencia { get; set; }
    }
}
