using System.Globalization;
using System.Text;
using Sentinels2.Data;
using Sentinels2.Models;
using Xceed.Words.NET;

namespace Sentinels2.Rules
{
    internal class Relatorios : IDisposable
    {
        public static string filenametosave = null; 
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
                filenametosave = $"Relatorios/ABONO_{funcionario.Id}{afastamento.DataInicial.ToString("yyyy-MM-dd")}";
                doc.SaveAs(filenametosave);
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
                filenametosave = $"Relatorios/FERIAS_{funcionario.Id}{afastamento.DataInicial.ToString("yyyy-MM-dd")}";
                doc.SaveAs(filenametosave);
            }
        }
        public void GerarLicencaPremio(Afastamento afastamento)
        {
            Vigia funcionario = VigiaCRUD.Find(p => p.Id.Equals(afastamento.Funcionario));
            string[] referencia = afastamento.Referencia.Split("-", 2);
            using (var doc = DocX.Load("Templates/TLicencaPremio.docx"))
            {
                doc.ReplaceText("${data}", afastamento.DataInicial.ToString("dd/MM/yyyy"));
                doc.ReplaceText("${nome}", funcionario.Nome);
                doc.ReplaceText("${matricula}", funcionario.Matricula);
                doc.ReplaceText("${cpf}", funcionario.CPF);
                doc.ReplaceText("${rg}", funcionario.RG);
                doc.ReplaceText("${cargo}", funcionario.Cargo);
                doc.ReplaceText("${lotacao}", funcionario.Lotacao);
                doc.ReplaceText("${telefone}", funcionario.Telefone);
                doc.ReplaceText("${endereco}", funcionario.Endereco);
                doc.ReplaceText("${email}", "vgmcatanduva@gmail.com");
                doc.ReplaceText("${qtd}", afastamento.QuantidadeDias.ToString());
                doc.ReplaceText("${data_inicio}", afastamento.DataInicial.ToString("d"));
                doc.ReplaceText("${referencia}", referencia[0]); // pegar até -
                doc.ReplaceText("${certidao}", referencia[1]);  // pegar de - em diante
                doc.ReplaceText("${data_doc}", DateTime.Now.ToString("dd/MM/yyyy"));
                doc.ReplaceText("${data_doc_ext}", $"{DateTime.Now.ToString("M")} de {DateTime.Now.Year}");
                filenametosave = $"Relatorios/PREMIO_{funcionario.Id}{afastamento.DataInicial.ToString("yyyy-MM-dd")}";
                doc.SaveAs(filenametosave);
            }
        }
        public void GerarLicencaMedica(Afastamento afastamento)
        {
            Vigia funcionario = VigiaCRUD.Find(p => p.Id.Equals(afastamento.Funcionario));
            using (var doc = DocX.Load("Templates/TLicencaSaude.docx"))
            {
                doc.ReplaceText("${nome}", funcionario.Nome);
                doc.ReplaceText("${cpf}", funcionario.CPF);
                doc.ReplaceText("${rg}", funcionario.RG);
                doc.ReplaceText("${endereco}", funcionario.Endereco);
                doc.ReplaceText("${cargo}", funcionario.Cargo);
                doc.ReplaceText("${lotacao}", funcionario.Lotacao);
                doc.ReplaceText("${matricula}", funcionario.Matricula);
                doc.ReplaceText("${telefone}", funcionario.Telefone);
                doc.ReplaceText("${email}", "vgmcatanduva@gmail.com");
                doc.ReplaceText("${qtd}", afastamento.QuantidadeDias.ToString());
                doc.ReplaceText("${data_inicial}", afastamento.DataInicial.ToString("d"));
                doc.ReplaceText("${data_doc_ext}", $"{DateTime.Now.ToString("M")} de {DateTime.Now.Year}");
                doc.ReplaceText("${inspetor}", afastamento.Referencia);
                filenametosave = $"Relatorios/SAUDE_{funcionario.Id}{afastamento.DataInicial.ToString("yyyy-MM-dd")}";
                doc.SaveAs(filenametosave);
            }
        }

        public void GerarAfastamento(Afastamento afastamento)
        {
            Vigia funcionario = VigiaCRUD.Find(p => p.Id.Equals(afastamento.Funcionario));
            string prefixo = RemoveSpecialCharacters(afastamento.TipoAfastamento);
            
            using (var doc = DocX.Load("Templates/TAfastamento.docx"))
            {
                doc.ReplaceText("${nome}", funcionario.Nome);
                doc.ReplaceText("${matricula}", funcionario.Matricula);
                doc.ReplaceText("${cpf}", funcionario.CPF);
                doc.ReplaceText("${rg}", funcionario.RG);
                doc.ReplaceText("${cargo}", funcionario.Cargo);
                doc.ReplaceText("${lotacao}", funcionario.Lotacao);
                doc.ReplaceText("${telefone}", funcionario.Telefone);
                doc.ReplaceText("${endereco}", funcionario.Endereco);
                doc.ReplaceText("${email}", "vgmcatanduva@gmail.com");
                doc.ReplaceText("${periodo_afastamento}", $"De {afastamento.DataInicial.ToString("d")} à {afastamento.DataFinal.ToString("d")}");
                doc.ReplaceText("${data_doc}", DateTime.Now.ToString("dd/MM/yyyy"));

                switch (afastamento.TipoAfastamento)
                {
                    case "Licença Casamento": doc.ReplaceText("${casamento}", "x"); break;
                    case "Doação de Sanguê": doc.ReplaceText("${sangue}", "x"); break;
                    case "Licença Paternidade": doc.ReplaceText("${paternidade}", "x"); break;
                    case "Licença Luto": doc.ReplaceText("${luto}", "x"); break;
                    case "TRE": doc.ReplaceText("${tre}", "x"); break;
                    case "Outros": doc.ReplaceText("${outros}", "x");
                                   doc.ReplaceText("${especificacao}", afastamento.Referencia);
                                   break;
                }

                if (afastamento.TipoAfastamento != "Licença Casamento") doc.ReplaceText("${casamento}", " ");
                if (afastamento.TipoAfastamento != "Doação de Sanguê") doc.ReplaceText("${sangue}", " ");
                if (afastamento.TipoAfastamento != "Licença Paternidade") doc.ReplaceText("${paternidade}", " ");
                if (afastamento.TipoAfastamento != "Licença Casamento") doc.ReplaceText("${luto}", " ");
                if (afastamento.TipoAfastamento != "Licença Luto") doc.ReplaceText("${tre}", " ");
                if (afastamento.TipoAfastamento != "TRE") doc.ReplaceText("${outros}", " ");
                if (afastamento.TipoAfastamento != "Outros") doc.ReplaceText("${outros}", " ");
                if (afastamento.TipoAfastamento != "Outros") doc.ReplaceText("${especificacao}", " ");
                filenametosave = $"Relatorios/{prefixo}_{funcionario.Id}{afastamento.DataInicial.ToString("yyyy-MM-dd")}";
                doc.SaveAs(filenametosave);
            }
        }

        public void GerarOrdemDeServico(List<Escala> escalas)
        {
            Vigia funcionario = VigiaCRUD.Find(p => p.Id.Equals(escalas[0].Vigia));
            string osn = DateTime.Now.ToString("MMddHHmmss");
            string referencia = $"{DateTime.Now.Year}-{funcionario.Matricula}{osn}";
            StringBuilder sb = new StringBuilder();

            escalas.ForEach(e => {
                sb.Append($"=> {e.Data.ToString("dd/MM/yyyy")} ({e.Data.ToString("ddd", new CultureInfo("pt-BR")).ToUpper()}) - {e.Patrimonio} : Das {e.Entrada.ToString("HH:mm")} às {e.Saida.ToString("HH:mm")} Horas\n");
            });


            using (var doc = DocX.Load("Templates/TOrdemDeServico.docx"))
            {
                doc.ReplaceText("${data_doc}", DateTime.Now.ToString("D"));
                doc.ReplaceText("${referencia}", referencia);
                doc.ReplaceText("${vigia}", funcionario.Nome);
                doc.ReplaceText("${matricula}", funcionario.Matricula);
                doc.ReplaceText("${cargo}", funcionario.Cargo);
                doc.ReplaceText("${plantoes}", sb.ToString());
                filenametosave = $"Relatorios/OS_{funcionario.Id}{referencia}";
                doc.SaveAs(filenametosave);
            }
        }
    
        public void GerarFolhaFrequencia(Vigia vigia, DateTime abertura)
        {
            using (var doc = DocX.Load("Templates/TFrequencia.docx"))
            {
                DateTime fechamento = abertura.AddMonths(1);
                int qtdDias = DateTime.DaysInMonth(abertura.Year, abertura.Month);
                string lastDay = (qtdDias == 31) ? "31" : " ";
                doc.ReplaceText("${nome}", vigia.Nome.ToUpper());
                doc.ReplaceText("${abertura}", $"{abertura.ToString("MMMM", new CultureInfo("pt-BR")).ToUpper()}/{abertura.Year}");
                doc.ReplaceText("${fechamento}", $"{fechamento.ToString("MMMM", new CultureInfo("pt-BR")).ToUpper()}/{fechamento.Year}");
                doc.ReplaceText("${ud}", lastDay);
                filenametosave = $"Relatorios/freq/{abertura.ToString("MMM")}-{vigia.Id}";
                doc.SaveAs(filenametosave);
            }
        }

        public void GerarOficioFrequencia(DateTime abertura)
        {
            OficioExpedido oficio = new OficioExpedido {
                Ano = abertura.Year,
                Ordem = OficioExpedidoCRUD.Get(p => p.Ano.Equals(abertura.Year)).Count() + 1,
                Destinatario = "DRH/Diretoria",
            };

            string ordem = (oficio.Ordem.ToString().Length > 2) ? $"00{oficio.Ordem}" : $"000{oficio.Ordem}";

            try
            {
                OficioExpedidoCRUD.Insert(oficio);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cuidado!\nO Oficio não foi Registrado");
            }

            StringBuilder sb = new StringBuilder();
            VigiaCRUD.GetAll().OrderBy(p => p.Nome).ToList().ForEach(v => {
                sb.Append($"=>\t\t{v.Nome} ({v.Cargo})\n");
            });

            using (var doc = DocX.Load("Templates/TFrequenciaOficio.docx"))
            {
                DateTime fechamento = abertura.AddMonths(1).AddDays(-1);
                int qtdDias = DateTime.DaysInMonth(abertura.Year, abertura.Month);
                string lastDay = (qtdDias == 31) ? "31" : " ";
                doc.ReplaceText("${data_doc}", DateTime.Now.ToString("D"));
                doc.ReplaceText("${id}", ordem);
                doc.ReplaceText("${referencia}", $"{abertura.ToString("MMMM", new CultureInfo("pt-BR")).ToUpper()}/{abertura.Year}");
                doc.ReplaceText("${data_inicial}", abertura.ToString("dd/MM/yyyy"));
                doc.ReplaceText("${data_final}", $"{fechamento.ToString("dd/MM/yyyy")}");
                doc.ReplaceText("${funcionarios}", sb.ToString());
                filenametosave = $"Relatorios/freq/OficioRH_{ordem}-{abertura.ToString("MMM")}";
                doc.SaveAs(filenametosave);
            }
        }

        public static string RemoveSpecialCharacters(string text, bool allowSpace = false)
        {
            string ret;

            if (allowSpace)
                ret = System.Text.RegularExpressions.Regex.Replace(text, @"[^0-9a-zA-ZéúíóáÉÚÍÓÁèùìòàÈÙÌÒÀõãñÕÃÑêûîôâÊÛÎÔÂëÿüïöäËYÜÏÖÄçÇ\s]+?", string.Empty);
            else
                ret = System.Text.RegularExpressions.Regex.Replace(text, @"[^0-9a-zA-ZéúíóáÉÚÍÓÁèùìòàÈÙÌÒÀõãñÕÃÑêûîôâÊÛÎÔÂëÿüïöäËYÜÏÖÄçÇ]+?", string.Empty);

            return ret;
        }

        public void Dispose()
        {
        }
    }
}
