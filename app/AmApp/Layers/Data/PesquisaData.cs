using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AmApp.Layers.Data
{
    public class PesquisaData
    {
        private Config.DbConnection _dbConn;


        public PesquisaData()
        {
            _dbConn = new Config.DbConnection();
            _dbConn.Connection.CreateTable<Model.Scraping>();
            _dbConn.Connection.CreateTable<Model.Pesquisa>();
            
        }

        public List<Model.Pesquisa> GetList()
        {
            var Pesquisa = _dbConn.Connection.GetAllWithChildren<Model.Pesquisa>().ToList();
            var Scrapping = _dbConn.Connection.Table<Model.Scraping>().ToList();

            foreach(Model.Pesquisa pesq in Pesquisa)
            {
                foreach(Model.Scraping scrap in Scrapping)
                {
                    if (scrap.LinkPesquisa.Equals(pesq.IdPesquisa))
                    {
                        var s = pesq.Scraping.Count;
                        pesq.Scraping.Add(scrap);
                    }
                }

            }

            return Pesquisa;
        }

        public Model.Pesquisa Get(int _id)
        {
            return _dbConn.Connection.Table<Model.Pesquisa>()
                          .Where(p => p.IdPesquisa == _id).SingleOrDefault();
        }

        public void Insert(Model.Pesquisa _pesquisaModel)
        {
            _dbConn.Connection.Insert(_pesquisaModel);
        }


        public void Delete(Model.Pesquisa _pesquisaModel)
        {
            _dbConn.Connection.Delete(_pesquisaModel);
        }

        public void DropTables()
        {
            _dbConn.Connection.DropTable<Model.Pesquisa>();
            _dbConn.Connection.CreateTable<Model.Pesquisa>();
        }

    }
}
