namespace Sentinels2.Models
{
    internal class OficioExpedido
    {
        public int Id { get; set; }
        public int Ano { get; set; }
        public int Ordem { get; set; }
        public string Destinatario { get; set; }
        public DateTime Entrega { get; set; }
        public string Assinatura { get; set; }
    }
}
