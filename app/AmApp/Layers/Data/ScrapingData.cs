using AmApp.Model;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AmApp.Layers.Data
{
    public class ScrapingData
    {
        private Config.DbConnection _dbConn;


        public ScrapingData()
        {
            _dbConn = new Config.DbConnection();
            _dbConn.Connection.CreateTable<Model.Scraping>();
        }

        public List<Model.Scraping> GetList()
        {
            return _dbConn.Connection.Table<Model.Scraping>().ToList();
        }

        public void Insert(Model.Pesquisa _pesquisaModel, int _id)
        {
            foreach(Scraping scrap in _pesquisaModel.Scraping)
            {
                scrap.LinkPesquisa = _id;
                _dbConn.Connection.Insert(scrap);
            }
            
        }


        public void Delete(Model.Scraping _pesquisaModel)
        {
            _dbConn.Connection.Delete(_pesquisaModel);
        }

        public void DropTables()
        {
            _dbConn.Connection.DropTable<Model.Scraping>();
            _dbConn.Connection.CreateTable<Model.Scraping>();
        }

    }
}
