using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Product
    {
        public static void Stock()
        {
            var stockChecker = new StockChecker();
            var stockLevelChecker = new StockLevelChecker();
            var stockAlert = new StockAlert();
            stockChecker.CheckStockLevel();
            stockLevelChecker.StockLevel(stockChecker);
            stockAlert.ShowStockAlerts(stockChecker);
        }
    }

}
