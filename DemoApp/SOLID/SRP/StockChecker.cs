namespace SOLID
{
    public class  StockChecker
    {
        public int StockLevel;

        public int CheckStockLevel()
        {
            var service = new ExternalService();
            StockLevel = service.GetStock();
            return StockLevel;
        }
    }

}
