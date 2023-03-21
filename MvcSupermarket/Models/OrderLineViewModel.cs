namespace MvcSupermarket.Models

{
    public class OrderLineViewModel
    {
        public int Quantity { get; set; }
        public double SubTotal { get; set; }
        public string ProductBarcode { get; set; }

    }
}
