using System.Collections.Generic;

namespace _11_Files
{
    interface IStockRepository
    {
        int NextId();

        void SaveStock(Stock asset);

        Stock LoadStock(long id);

        List<IAsset> FindAllStocks();

        void Clear();
    }
}
