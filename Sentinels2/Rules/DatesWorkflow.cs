using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentinels2.Rules
{
    internal class DatesWorkflow
    {
        public static int TempoDeCasa(DateTime adimissao)
        {
            int t = DateTime.Now.Year - adimissao.Year;
            if(DateTime.Now.Month < adimissao.Month)
            {
                t -= 1;
            }
            return t;
        }

        public static string IdadePrecisa(DateTime dataNasimento)
        {
            DateTime current = DateTime.Now;
            var y = (current.Year - dataNasimento.Year);
            if(current.Month < dataNasimento.Month)
            {
                y -= 1;
            }
            //var m = (DateTime.Now - dataNasimento).TotalDays;
            //var d = (DateTime.Now - dataNasimento);
            return $"{y} anos de idade";
        }
    }
}
