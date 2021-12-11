using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentinels2.Models
{
    internal class Patrimonio
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Setor { get; set; }
        public int TipoVigilancia { get; set; }
        public TimeSpan HoraReferencia { get; set; }
    }
}
