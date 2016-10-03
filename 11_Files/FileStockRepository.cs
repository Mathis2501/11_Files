using System;
using System.Collections.Generic;
using System.IO;

namespace _11_Files
{
    internal class FileStockRepository : IStockRepository, IFileRepository
    {
        private int id = 0;
        private DirectoryInfo repositoryDir;

        public FileStockRepository(DirectoryInfo repositoryDir)
        {
            this.repositoryDir = repositoryDir;
        }

        public int NextId()
        {
            id++;
            return id;
        }

        public void SaveStock(Stock asset)
        {
            asset.Id = NextId();
            StreamWriter writer = new StreamWriter(repositoryDir+"\\stock"+asset.Id+".txt");
            writer.WriteLine(asset.ToString());
            writer.Close();
        }

        public Stock LoadStock(long id)
        {
            throw new System.NotImplementedException();
        }

        public List<IAsset> FindAllStocks()
        {
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        public string StockFileName(long id)
        {
            return "stock" + id + ".txt";
        }

        public string StockFileName(Stock stock)
        {
            return "stock" + stock.Id + ".txt";
        }
    }
}