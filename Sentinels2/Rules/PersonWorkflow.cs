using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Text.Encodings.Web;
using System.Web;
using Sentinels2.Data;
using Sentinels2.Models;

namespace Sentinels2.Rules
{
    internal class PersonWorkflow
    {
        public static List<Vigia> AvailableOnDate(DateTime date, string periodo = "A")
        {
            List<Vigia> vigias = new List<Vigia>();

            VigiaCRUD.GetAll().ToList().ForEach(v => {
                if (EscalaCRUD.Get(p => p.Vigia.Equals(v.Id) && p.Data.Equals(date)).Count() < 1)
                {
                    if(AfastamentoCRUD.Get(p => p.Funcionario.Equals(v.Id) && (p.DataInicial <= date && p.DataFinal >= date)).ToList().Count() < 1)
                    {
                        vigias.Add(v);
                    }

                    /// Consulta ROW
                    /// 

                    //using (Context ctx = new Context())
                    //{
                    //    var data = ctx.Afastamentos.FromSqlRaw($"select * from Afastamento where Funcionario = '{v.Id}' and (DataInicial <= '{date.ToString("yyyy-MM-dd")}' AND DataFinal >= '{date.ToString("yyyy-MM-dd")}')").ToList();
                    //    if(data.Count < 1)
                    //    {
                    //        vigias.Add(v);
                    //    }
                    //}
                }
            });

            return vigias;
        }

        public static void Escalar(int os, string pessoa, string faturamento)
        {
            var escala = EscalaCRUD.Find(p => p.OS.Equals(os));
            escala.Vigia = pessoa;
            escala.TipoPagamento = faturamento;
            EscalaCRUD.Update(escala);
        }

        public static void Designate(string local, DateTime inicio, DateTime fim, string vigia1, string vigia2, string turno)
        {
            List<Escala> escalas = new List<Escala>();
            // Escalas para o Patrimônio atual no período de tempo especificado

            switch(turno)
            {
                case "N":
                    {
                        escalas = EscalaCRUD.Get(p => p.Patrimonio.Equals(local) 
                                  && (p.Data >= inicio && p.Data <= fim) 
                                  && (p.Saida.Hour < p.Entrada.Hour)).ToList();
                        break;
                    }
                case "D":
                    {
                        escalas = EscalaCRUD.Get(p => p.Patrimonio.Equals(local) 
                                  && (p.Data >= inicio && p.Data <= fim) 
                                  && (p.Saida.Hour > p.Entrada.Hour)).ToList();
                        break;
                    }
            }

            int ctrl = 0;
            foreach (var item in escalas)
            {
                switch(ctrl)
                {
                     case 0:
                     {
                         item.Vigia = vigia1;
                         ctrl = 1;
                         break;
                     }
                     case 1:
                     {
                         item.Vigia = vigia2;
                         ctrl = 0;
                         break;
                     }
                }

                // Atualizando

                try
                {
                    item.TipoPagamento = "NORMAL";
                    EscalaCRUD.Update(item);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void SendMsgTo(List<Escala> escalas)
        {
            Vigia v = VigiaCRUD.Find(escalas[0].Vigia);
            string termo = "*Ao confirmar, você se compromete a realizar os plantões aqui listados.*\n*Devendo comunicar o surgimento de qualquer imprevisto que inviabilize sua realização.*\n\nPara aceitar, Responda essa menssagem com a palavra em maiúsculo: *ACEITO*";
            StringBuilder sb = new StringBuilder();
            sb.Append($"*{v.Id}*\n\n");
            escalas.ForEach(e => {
                sb.Append($"=>\t{e.Data.ToString("dd/MM/yyyy")} ({e.Data.ToString("ddd", new CultureInfo("pt-BR")).ToUpper()}) - {e.Patrimonio}\n\tDas {e.Entrada.ToString("HH:mm")} às {e.Saida.ToString("HH:mm")} Horas - {e.TipoPagamento}\n\n");
            });
            sb.Append($"\n\n{termo}");

            string browserURi = "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe";
            string apiurl = "https://api.whatsapp.com/send?phone=55";
            string telefone = v.Telefone.Replace("-","").Replace(" ", "");
            var msg = HttpUtility.UrlPathEncode(sb.ToString());
            string url = $"{apiurl}{telefone}&text={msg}";
            Process.Start(browserURi, url);
        }
    }
}
