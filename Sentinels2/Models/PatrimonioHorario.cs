namespace Sentinels2.Models
{
    internal class PatrimonioHorario : IDisposable
    {
        public string PatrimonioId { get; set; }
        public TimeSpan Entrada { get; set; }
        public TimeSpan Saida { get; set; }
        public double Duracao { get; set; }
        public string Motivo { get; set; }
        public void Dispose()
        {
           
        }
    }
}
