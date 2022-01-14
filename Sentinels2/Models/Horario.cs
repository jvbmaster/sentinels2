namespace Sentinels2.Models
{
    internal class Horario : IDisposable
    {
        public static TimeSpan entrada;

        public static TimeSpan saida;
        public static string motivo;
        public TimeSpan Entrada { get; set; }
        public TimeSpan Saida { get; set; }

        public void Dispose()
        {
            
        }
    }
}
