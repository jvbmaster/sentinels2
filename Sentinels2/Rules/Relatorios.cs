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
                doc.ReplaceText("${nome}", vigia.Nome.ToUpper());
                doc.ReplaceText("${abertura}", $"{abertura.ToString("MMMM", new CultureInfo("pt-BR")).ToUpper()}/{abertura.Year}");
                doc.ReplaceText("${fechamento}", $"{fechamento.ToString("MMMM", new CultureInfo("pt-BR")).ToUpper()}/{fechamento.Year}");
                doc.ReplaceText("${ud}", qtdDias.ToString());
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

        public void FecharFolhaFrequencia(Vigia vigia, List<Afastamento> listaAfastamentos, List<Escala> escalaFixa)
        {
            
            StringBuilder afastamentos = new StringBuilder();
            string tipoEscala = $"12x36 das {escalaFixa.First().Entrada.ToString("HH:mm")} às {escalaFixa.First().Saida.ToString("HH:mm")} Horas";
            string cod6Check = "";
            string cod6qtd = "";
            string qtdDiasAfastamento = "";
            string cod24check = (vigia.Turno == "N") ? "24" : " ";

            int diasTrabalhados = escalaFixa.Count();
            int horasTrabalhadas = diasTrabalhados * 12;
            int jornadaExcedente = (horasTrabalhadas / 40) * 2; 
           // int jornadaSemanal = (horasTrabalhadas/40) * 2;
           // jornadaExcedente = jornadaSemanal;
           // for (int i = 0; i < jornadaSemanal; i++)
           // {
           //     jornadaExcedente += 2;
           // }

            foreach (var item in listaAfastamentos)
            {
                qtdDiasAfastamento = (item.TipoAfastamento != "Abono") ? $" de {item.QuantidadeDias} dia(s)" : "";
                afastamentos.AppendLine($"{item.DataInicial.ToString("dd/MM")} : {item.TipoAfastamento} {qtdDiasAfastamento}");
            }
            
            if(jornadaExcedente < 0)
            {
                cod6Check = " ";
                cod6qtd = " ";
            }
            else
            {
                cod6Check = "06";
                cod6qtd = $"{jornadaExcedente} Horas";
            }

            using (var doc = DocX.Load("Templates/TFrequenciaVerso.docx"))
            {
                doc.ReplaceText("${funcionario}", vigia.Nome);
                doc.ReplaceText("${cargo}", vigia.Cargo);
                doc.ReplaceText("${matricula}", vigia.Matricula);
                doc.ReplaceText("${escala_tipo}", tipoEscala);
                doc.ReplaceText("${cod6}", cod6Check);
                doc.ReplaceText("${cod6_qtd}", cod6qtd);
                doc.ReplaceText("${cod24}", cod24check);
                doc.ReplaceText("${afastamentos}", afastamentos.ToString());
                filenametosave = $"Relatorios/fechamento/{vigia.Nome}.docx";
                doc.SaveAs(filenametosave);
            }
        }

        public void GerarConvocacao(FechamentoHoraExtra fechamento)
        {
            Convocacao convocacao = new Convocacao();
            convocacao = fechamento.Convocacao;
            using (var doc = DocX.Load("Templates/TConvocacao.docx"))
            {
                doc.ReplaceText("${data_doc}", DateTime.Now.ToString("dd/MM/yyyy"));
                doc.ReplaceText("${proprietario}", "Claúdio Manoel da Costa Franco Pereira");
                doc.ReplaceText("${carimbo}", "Claúdio Manoel da Costa Franco Pereira");
                doc.ReplaceText("${periodo}", $"{convocacao.DataInicial.ToString("dd/MM/yyyy")} à {convocacao.DataFinal.ToString("dd/MM/yyyy")}");
                doc.ReplaceText("${matricula}", convocacao.Funcionario.Matricula);
                doc.ReplaceText("${funcionario}", convocacao.Funcionario.Nome);
                doc.ReplaceText("${cargo}", convocacao.Funcionario.Cargo);

                // Horas
                int i = 0;
                foreach (var item in convocacao.HorasRealizadas)
                {
                    i++; // incrementa numero da linha no documento
                    
                    doc.ReplaceText($"DT{i}", item.Data.ToString("dd/MM"));
                    doc.ReplaceText($"HR{i}", $"{item.Entrada.ToString("HH:mm")} às {item.Saida.ToString("HH:mm")}");
                    doc.ReplaceText($"SD{i}", $"{item.SimplesDiurna.Hours.ToString().PadLeft(2,'0')}:{item.SimplesDiurna.Minutes.ToString().PadLeft(2, '0')}");
                    doc.ReplaceText($"SN{i}", $"{item.SimplesNoturna.Hours.ToString().PadLeft(2, '0')}:{item.SimplesNoturna.Minutes.ToString().PadLeft(2, '0')}");
                    doc.ReplaceText($"PD{i}", $"{item.PlantaoDiurna.Hours.ToString().PadLeft(2, '0')}:{item.PlantaoDiurna.Minutes.ToString().PadLeft(2, '0')}");
                    doc.ReplaceText($"PN{i}", $"{item.PlantaoNoturna.Hours.ToString().PadLeft(2, '0')}:{item.PlantaoNoturna.Minutes.ToString().PadLeft(2, '0')}");
                    doc.ReplaceText($"JS{i}", $"{item.Justificativa}");
                }

                //Limpa linhas remanescentes

                while (i < 18)
                {
                    doc.ReplaceText($"DT{i}", " ");
                    doc.ReplaceText($"HR{i}", " ");
                    doc.ReplaceText($"SD{i}", " ");
                    doc.ReplaceText($"SN{i}", " ");
                    doc.ReplaceText($"PD{i}", " ");
                    doc.ReplaceText($"PN{i}", " ");
                    doc.ReplaceText($"JS{i}", " ");
                    i++;
                }
                // Adiciona totais

                convocacao.Totalizar();

                doc.ReplaceText($"TSD", convocacao.SimplesDiaTotal.ToString());
                doc.ReplaceText($"TSN", convocacao.SimplesNoiteTotal.ToString());
                doc.ReplaceText($"TPD", convocacao.PlantaoDiaTotal.ToString());
                doc.ReplaceText($"TPN", convocacao.PlantaoNoiteTotal.ToString());
                //

                filenametosave = $"Relatorios/convoc/{convocacao.DataInicial.Month}-{convocacao.Funcionario.Nome}";
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
