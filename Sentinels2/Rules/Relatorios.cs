using Sentinels2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;

namespace Sentinels2.Rules
{
    internal class Relatorios
    {
        public void Salvar(DocX document, string fileName)
        {
            document.SaveAs(fileName);
        }
        public void GerarAbonada(Vigia funcionario, DateTime data)
        {
            using (var doc = DocX.Load("TAbonada.docx"))
            {
                doc.ReplaceText("${data}", data.ToString("dd/MM/yyyy"));
                doc.ReplaceText("${data_doc}", DateTime.Now.ToString("dd/MM/yyyy"));
                doc.ReplaceText("${nome}", funcionario.Nome);
                doc.ReplaceText("${matricula}", funcionario.Matricula);
                doc.ReplaceText("${CPF}", funcionario.CPF);
                doc.ReplaceText("${RG}", funcionario.RG);
                doc.ReplaceText("${cargo}", funcionario.Cargo);
                doc.ReplaceText("${lotacao}", funcionario.Lotacao);
                doc.ReplaceText("${tel_movel}", funcionario.TelefonePessoal);
                doc.ReplaceText("${endereco}", funcionario.Endereco);
                doc.ReplaceText("${email}", "vgmcatanduva@gmail.com");
            }
        }

        public void GerarFerias(Vigia membro, int qtdDias, OpcaoDeFerias referencia)
        {
            using (var doc = DocX.Load("TFerias.docx"))
            {

            }
        }
        public void GerarLicencaPremio(Vigia membro, int qtdDias, LicencaPremio referencia)
        {
            using (var doc = DocX.Load("TLicencaPremio.docx"))
            {

            }
        }
        public void GerarLicencaMedica(Vigia membro, int qtdDias, bool anterior, bool familia)
        {
            using (var doc = DocX.Load("TLicencaMedica.docx"))
            {

            }
        }
        public void GerarAfastamento(Vigia membro, int qtdDias, string tipo)
        {
            using (var doc = DocX.Load("Tafastamento.docx"))
            {

            }
        }

        
    }
}
