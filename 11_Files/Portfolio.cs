using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace _11_Files
{
    class Portfolio
    {
        public List<IAsset> Stocks = new List<IAsset>();
        public Portfolio(List<IAsset> stocks)
        {
            Stocks = stocks;
        }

        public Portfolio()
        {

        }

        public double GetTotalValue()
        {
            double total = 0;
            foreach (IAsset item in Stocks)
            {
                total += item.GetValue();
            }
            return total;
        }

        public void AddAsset(IAsset origAsset)
        {
            Stocks.Add(origAsset);
        }

        public IList<IAsset> GetAssets()
        {
            IReadOnlyList<IAsset> assets = new ReadOnlyCollection<IAsset>(Stocks);
            return (IList<IAsset>)assets;
        }

        public IAsset GetAssetByName(string name)
        {
            foreach (IAsset item in Stocks)
            {
                if (item.GetName() == name)
                {
                    return item;
                }                    
            }
            return null;
        }

        public IList<IAsset> GetAssetsSortedByName()
        {
            Dictionary<string, IAsset> assets = new Dictionary<string, IAsset>();
            foreach (IAsset a in Stocks)
            {
                assets.Add(a.GetName(), a);
            }
            List<string> sorter = new List<string>(assets.Keys);
            sorter.Sort();
            List<IAsset> newList = new List<IAsset>();
            foreach (var item in sorter)
            {
                newList.Add(assets[item]);
            }

            return newList;
        }

        public IList<IAsset> GetAssetsSortedByValue()
        {
            Dictionary<double, IAsset> assets = new Dictionary<double, IAsset>();
            foreach (IAsset a in Stocks)
            {
                assets.Add(a.GetValue(), a);
            }
            List<double> sorter = new List<double>(assets.Keys);
            sorter.Sort();
            sorter.Reverse();
            List<IAsset> newList = new List<IAsset>();
            foreach (var item in sorter)
            {
                newList.Add(assets[item]);
            }

            return newList;
        }

    }
}
