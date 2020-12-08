namespace DemoApp
{
    public class  StockChecker
    {
        public int StockLevel;

        public void CheckStockLevel()
        {
            var service = new ExternalService();
            StockLevel = service.GetStock();
        }
    }

}
