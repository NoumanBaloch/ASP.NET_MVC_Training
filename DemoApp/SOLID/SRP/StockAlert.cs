using System;

namespace SOLID
{
    public class StockAlert
    {
        public void ShowStockAlerts(StockChecker stockChecker)
        {
            Console.WriteLine("Stock is Low", stockChecker.StockLevel);
        }
    }

}
