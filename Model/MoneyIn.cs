namespace LZDemo.Model
{
    public class MoneyIn
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Customer { get; set; }
        public string Details { get; set; }
        public string ReceiptNo { get; set; }
        public double TotalReceipts { get; set; }
        public double GST { get; set; }
    }
}
