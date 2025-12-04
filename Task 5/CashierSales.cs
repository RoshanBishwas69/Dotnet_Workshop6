namespace Workshop6
{
    public class CashierSales
    {
        public string CashierName { get; set; }
        public double SalesAmount { get; set; }

        public CashierSales(string name, double sales)
        {
            CashierName = name;
            SalesAmount = sales;
        }
    }
}