namespace Types2
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    struct GoodInfo
    {
        public int Quantity;
        public decimal Price;
        public string Good;

        public GoodInfo(string good, decimal price, int quantity)
        {
            this.Good = good;
            this.Price = price;
            this.Quantity = quantity;
        }
    }
}
