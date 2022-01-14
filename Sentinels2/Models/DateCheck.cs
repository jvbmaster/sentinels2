namespace Sentinels2.Models
{
    internal class DateCheck : EventArgs
    {
        public static List<DateCheck> Dates = new List<DateCheck>();
        public bool Checked { get; set; }
        public DateTime Date { get; set; }


        public event EventHandler<DateCheck> CheckedChanged;

        protected virtual void OnCheckedChanged(DateCheck e)
        {
            // Safely raise the event for all subscribers
            CheckedChanged?.Invoke(this, e);
        }
    }
}
