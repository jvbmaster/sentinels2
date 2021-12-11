namespace Sentinels2.Models
{
    internal class Vigia
    {
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public DateTime Nascimento { get; set; }
        public DateTime Admissao { get; set; }
        public string Cargo { get; set; }
        public string Lotacao { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string RH { get; set; }
        public string TelefonePessoal { get; set; }
        public string TelefoneResidencial { get; set; }
        public string Endereco { get; set; }
        public string AvatarPath { get; set; }
        public Desligamento Desligamento { get; set; }
    }
}
