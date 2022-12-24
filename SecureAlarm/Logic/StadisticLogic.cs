using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using KosmoSecure.DB;
using System.Data.SQLite;

namespace KosmoSecure.Logic
{
    public class StadisticLogic
    {
        private static string galaxy = ConfigurationManager.ConnectionStrings["galaxy"].ConnectionString;
        private static StadisticLogic _instancia = null;
        public static List<Stadistic> olista = new List<Stadistic>();

        public static StadisticLogic instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new StadisticLogic();
                }
                return _instancia;
            }
        }
        public bool Add(Stadistic obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(galaxy))
            {
                conexion.Open();
                string query = "insert into Stadistic(Date) values (@date)";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@date", obj.Date));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }
        public bool Edit(Stadistic obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(galaxy))
            {
                conexion.Open();
                string query = "Update Stadistic set Date=@date where id=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@id", obj.id));
                cmd.Parameters.Add(new SQLiteParameter("@date", obj.Date));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }
        public bool Delete(Stadistic obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(galaxy))
            {
                conexion.Open();
                string query = "delete from Stadistic where id=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@id", obj.id));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }
        public List<Stadistic> Listar()
        {
            olista.Clear();
            using (SQLiteConnection conexion = new SQLiteConnection(galaxy))
            {
                conexion.Open();
                string query = "select * from Stadistic";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        olista.Add(new Stadistic()
                        {
                            id = int.Parse(dr["id"].ToString()),
                            Date = int.Parse(dr["Date"].ToString())
                        });
                    }
                }
            }
            return olista;
        }
    }
}
