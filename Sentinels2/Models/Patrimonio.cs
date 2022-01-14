namespace Sentinels2.Models
{
    internal class Patrimonio
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public int TipoVigilancia { get; set; }
        public TimeSpan HoraReferencia { get; set; }
        public string DescricaoVigilancia { get; set; }
    }
}
