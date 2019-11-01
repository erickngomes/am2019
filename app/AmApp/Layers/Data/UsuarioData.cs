using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AmApp.Layers.Data
{
    public class UsuarioData
    {
        private Config.DbConnection _dbConn;


        public UsuarioData()
        {
            _dbConn = new Config.DbConnection();
            _dbConn.Connection.CreateTable<Model.Usuario>();
        }

        public List<Model.Usuario> GetList()
        {
            return _dbConn.Connection.Table<Model.Usuario>().ToList();
        }

        public Model.Usuario Get()
        {
            return _dbConn.Connection.Table<Model.Usuario>().FirstOrDefault();
        }

        public void Insert(Model.Usuario _usuarioModel)
        {
            _dbConn.Connection.Insert(_usuarioModel);
        }


        public void Delete(Model.Usuario _usuarioModel)
        {
            _dbConn.Connection.Delete(_usuarioModel);
        }

        public void DropTables()
        {
            _dbConn.Connection.DropTable<Model.Usuario>();
            _dbConn.Connection.CreateTable<Model.Usuario>();
        }


    }
}
