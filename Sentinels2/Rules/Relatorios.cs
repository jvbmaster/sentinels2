using System.Globalization;
using System.Text;
using Sentinels2.Data;
using Sentinels2.Models;
using Xceed.Words.NET;

namespace Sentinels2.Rules
{
    internal class Relatorios
    {
        public void GerarAbonada(Afastamento afastamento)
        {
            Vigia funcionario = VigiaCRUD.Find(p => p.Id.Equals(afastamento.Funcionario));
            using (var doc = DocX.Load("Templates/TAbonada.docx"))
            {
                doc.ReplaceText("${data}", afastamento.DataInicial.ToString("dd/MM/yyyy"));
                doc.ReplaceText("${data_doc}", DateTime.Now.ToString("dd/MM/yyyy"));
                doc.ReplaceText("${nome}", funcionario.Nome);
                doc.ReplaceText("${matricula}", funcionario.Matricula);
                doc.ReplaceText("${cpf}", funcionario.CPF);
                doc.ReplaceText("${rg}", funcionario.RG);
                doc.ReplaceText("${cargo}", funcionario.Cargo);
                doc.ReplaceText("${lotacao}", funcionario.Lotacao);
                doc.ReplaceText("${telefone}", funcionario.Telefone);
                doc.ReplaceText("${endereco}", funcionario.Endereco);
                doc.ReplaceText("${email}", "vgmcatanduva@gmail.com");
                doc.SaveAs($"Relatorios/abono{funcionario.Id}{afastamento.DataInicial.ToString("yyyy-MM-dd")}");
            }
        }

        public void GerarFerias(Afastamento afastamento)
        {
            Vigia funcionario = VigiaCRUD.Find(p => p.Id.Equals(afastamento.Funcionario));
            using (var doc = DocX.Load("Templates/TFerias.docx"))
            {
                doc.ReplaceText("${data_inicio}", afastamento.DataInicial.ToString("dd/MM/yyyy"));
                doc.ReplaceText("${data_doc}", DateTime.Now.ToString("dd/MM/yyyy"));
                doc.ReplaceText("${referencia}", afastamento.Referencia);
                doc.ReplaceText("${nome}", funcionario.Nome);
                doc.ReplaceText("${matricula}", funcionario.Matricula);
                doc.ReplaceText("${cpf}", funcionario.CPF);
                doc.ReplaceText("${rg}", funcionario.RG);
                doc.ReplaceText("${cargo}", funcionario.Cargo);
                doc.ReplaceText("${lotacao}", funcionario.Lotacao);
                doc.ReplaceText("${telefone}", funcionario.Telefone);
                doc.ReplaceText("${endereco}", funcionario.Endereco);
                doc.ReplaceText("${email}", "vgmcatanduva@gmail.com");
                switch(afastamento.QuantidadeDias)
                {
                    case 30: { 
                            doc.ReplaceText("${t}", "[x]");
                            doc.ReplaceText("${p}", "[ ]");
                            doc.ReplaceText("${m}", "[ ]");
                            break; 
                        }
                    case 20: { 
                            doc.ReplaceText("${p}", "[x]");
                            doc.ReplaceText("${t}", "[ ]");
                            doc.ReplaceText("${m}", "[ ]");
                            break; 
                        }
                    case 15: { 
                            doc.ReplaceText("${m}", "[x]");
                            doc.ReplaceText("${t}", "[ ]");
                            doc.ReplaceText("${p}", "[ ]"); 
                            break; 
                        }
                }
                doc.SaveAs($"Relatorios/ferias{funcionario.Id}{afastamento.DataInicial.ToString("yyyy-MM-dd")}");
            }
        }
        public void GerarLicencaPremio(Afastamento afastamento)
        {
            using (var doc = DocX.Load("Templates/TLicencaPremio.docx"))
            {

            }
        }
        public void GerarLicencaMedica(Afastamento afastamento)
        {
            using (var doc = DocX.Load("Templates/TLicencaMedica.docx"))
            {

            }
        }
        public void GerarAfastamento(Afastamento afastamento)
        {
            using (var doc = DocX.Load("Templates/TAfastamento.docx"))
            {

            }
        }

        public void GerarOrdemDeServico(List<Escala> escalas)
        {
            Vigia funcionario = VigiaCRUD.Find(p => p.Id.Equals(escalas[0].Vigia));
            string osn = DateTime.Now.ToString("MMddHHmmss");
            string referencia = $"{DateTime.Now.Year}-{funcionario.Matricula}{osn}";
            StringBuilder sb = new StringBuilder();

            escalas.ForEach(e => {
                sb.Append($"{e.Data.ToString("dd/MM/yyyy")} ({e.Data.ToString("ddd", new CultureInfo("pt-BR")).ToUpper()}) - {e.Patrimonio} : Das {e.Entrada.ToString("HH:mm")} às {e.Saida.ToString("HH:mm")} Horas\n");
            });


            using (var doc = DocX.Load("Templates/TOrdemDeServico.docx"))
            {
                doc.ReplaceText("${data_doc}", DateTime.Now.Date.ToString("D"));
                doc.ReplaceText("${referencia}", referencia);
                doc.ReplaceText("${vigia}", funcionario.Nome);
                doc.ReplaceText("${matricula}", funcionario.Matricula);
                doc.ReplaceText("${cargo}", funcionario.Cargo);
                doc.ReplaceText("${plantoes}", sb.ToString());
                doc.SaveAs($"Relatorios/os{funcionario.Id}{referencia}");
            }
        }

    }
}
