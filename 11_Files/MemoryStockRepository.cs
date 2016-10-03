using System.Collections.Generic;

namespace _11_Files
{
    class MemoryStockRepository : IStockRepository
    {
        private int _id;
        public List<IAsset> Assets = new List<IAsset>();

        public int NextId()
        {
            _id++;
            return _id;

        }

        public void SaveStock(Stock a)
        {
            Assets.Add(a);
        }

        public Stock LoadStock(long id)
        {
            foreach (var asset in Assets)
            {
                var a = (Stock) asset;
                if (a.Id == id)
                {
                    return a;
                }
            }
            return null;
        }

        public List<IAsset> FindAllStocks()
        {
            return Assets;
        }

        public void Clear()
        {
            Assets.Clear();
        }
    }
}
