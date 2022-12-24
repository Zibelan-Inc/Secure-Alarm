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
    public class LogLogic
    {
        private static string galaxy = ConfigurationManager.ConnectionStrings["galaxy"].ConnectionString;
        private static LogLogic _instancia = null;
        public static List<Log> olista = new List<Log>();

        public static LogLogic instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new LogLogic();
                }
                return _instancia;
            }
        }
        public bool Add(Log obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(galaxy))
            {
                conexion.Open();
                string query = "insert into Log(Date,Description,IP) values (@date,@description,@ip)";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@date", obj.Date));
                cmd.Parameters.Add(new SQLiteParameter("@description", obj.Description));
                cmd.Parameters.Add(new SQLiteParameter("@ip", obj.IP));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }
        public bool Edit(Log obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(galaxy))
            {
                conexion.Open();
                string query = "Update Log set Date=@date,Description=@description,IP=@ip where id=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@id", obj.id));
                cmd.Parameters.Add(new SQLiteParameter("@date", obj.Date));
                cmd.Parameters.Add(new SQLiteParameter("@description", obj.Description));
                cmd.Parameters.Add(new SQLiteParameter("@ip", obj.IP));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }
        public bool Delete(Log obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(galaxy))
            {
                conexion.Open();
                string query = "delete from Log where id=@id";
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
        public List<Log> Listar()
        {
            olista.Clear();
            using (SQLiteConnection conexion = new SQLiteConnection(galaxy))
            {
                conexion.Open();
                string query = "select * from Log";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        olista.Add(new Log()
                        {
                            id = int.Parse(dr["id"].ToString()),
                            Date = dr["Date"].ToString(),
                            Description = dr["Description"].ToString(),
                            IP = dr["IP"].ToString()
                        });
                    }
                }
            }
            return olista;
        }
    }
}
