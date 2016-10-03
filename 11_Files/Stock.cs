using System.Globalization;

namespace _11_Files
{
    class Stock : IAsset
    {
        public int Id;
        public string Symbol;
        public double PricePerShare;
        public double NumShares;

        public Stock()
        {
            
        }

        public Stock(string symbol, double pricePerShare, double numShares)
        {
            Symbol = symbol;
            PricePerShare = pricePerShare;
            NumShares = numShares;
        }

        public double GetValue()
        {
            return NumShares * PricePerShare;
        }

        public static double TotalValue(Stock[] stocks)
        {
            double total = 0;
            foreach (Stock stock in stocks)
            {
                total += stock.NumShares * stock.PricePerShare;
            }
            return total;
        }

        public static double TotalValue(IAsset[] stocks)
        {
            double total = 0;
            foreach (IAsset item in stocks)
            {
                total += item.GetValue();
            }
            return total;
        }

        public override string ToString()
        {
            return "Stock[symbol=" + Symbol + ",pricePerShare=" + PricePerShare.ToString(CultureInfo.InvariantCulture).Replace(",",".") + ",numShares=" + NumShares + "]";
        }

        public bool Equals(Stock stock)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            if (stock.Symbol != Symbol || stock.PricePerShare != PricePerShare || stock.NumShares != NumShares)
                return true;
            return false;
        }

        public string GetName()
        {
            return Symbol;
        }



    }
}
