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
    public class AlarmLogic
    {
        private static string galaxy = ConfigurationManager.ConnectionStrings["galaxy"].ConnectionString;
        private static AlarmLogic _instancia = null;
        public static List<Alarm> olista = new List<Alarm>();

        public static AlarmLogic instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new AlarmLogic();
                }
                return _instancia;
            }
        }
        public bool Add(Alarm obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(galaxy))
            {
                conexion.Open();
                string query = "insert into Alarm(Name,State,HourEnabled,HourDisabled,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday,Programer,IP) values (@name,@state,@hourenabled,@hourdisabled,@monday,@tuesday,@wednesday,@thursday,@friday,@saturday,@sunday,@programer,@ip)";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@name", obj.Name));
                cmd.Parameters.Add(new SQLiteParameter("@state", obj.State));
                cmd.Parameters.Add(new SQLiteParameter("@hourenabled", obj.HourEnabled));
                cmd.Parameters.Add(new SQLiteParameter("@hourdisabled", obj.HourDisabled));
                cmd.Parameters.Add(new SQLiteParameter("@monday", obj.Monday));
                cmd.Parameters.Add(new SQLiteParameter("@tuesday", obj.Tuesday));
                cmd.Parameters.Add(new SQLiteParameter("@wednesday", obj.Wednesday));
                cmd.Parameters.Add(new SQLiteParameter("@thursday", obj.Thursday));
                cmd.Parameters.Add(new SQLiteParameter("@friday", obj.Friday));
                cmd.Parameters.Add(new SQLiteParameter("@saturday", obj.Saturday));
                cmd.Parameters.Add(new SQLiteParameter("@sunday", obj.Sunday));
                cmd.Parameters.Add(new SQLiteParameter("@programer", obj.Programer));
                cmd.Parameters.Add(new SQLiteParameter("@ip", obj.IP));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }
        public bool Edit(Alarm obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(galaxy))
            {
                conexion.Open();
                string query = "Update Alarm set Name=@name,State=@state,HourEnabled=@hourenabled,HourDisabled=@hourdisabled,Monday=@monday,Tuesday=@tuesday,Wednesday=@wednesday,Thursday=@thursday,Friday=@friday,Saturday=@saturday,Sunday=@sunday,Programer=@programer,IP=@ip where id=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@id", obj.id));
                cmd.Parameters.Add(new SQLiteParameter("@name", obj.Name));
                cmd.Parameters.Add(new SQLiteParameter("@state", obj.State));
                cmd.Parameters.Add(new SQLiteParameter("@hourenabled", obj.HourEnabled));
                cmd.Parameters.Add(new SQLiteParameter("@hourdisabled", obj.HourDisabled));
                cmd.Parameters.Add(new SQLiteParameter("@monday", obj.Monday));
                cmd.Parameters.Add(new SQLiteParameter("@tuesday", obj.Tuesday));
                cmd.Parameters.Add(new SQLiteParameter("@wednesday", obj.Wednesday));
                cmd.Parameters.Add(new SQLiteParameter("@thursday", obj.Thursday));
                cmd.Parameters.Add(new SQLiteParameter("@friday", obj.Friday));
                cmd.Parameters.Add(new SQLiteParameter("@saturday", obj.Saturday));
                cmd.Parameters.Add(new SQLiteParameter("@sunday", obj.Sunday));
                cmd.Parameters.Add(new SQLiteParameter("@programer", obj.Programer));
                cmd.Parameters.Add(new SQLiteParameter("@ip", obj.IP));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }
        public bool Delete(Alarm obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(galaxy))
            {
                conexion.Open();
                string query = "delete from Alarm where id=@id";
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
        public List<Alarm> Listar()
        {
            olista.Clear();
            using (SQLiteConnection conexion = new SQLiteConnection(galaxy))
            {
                conexion.Open();
                string query = "select * from Alarm";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        olista.Add(new Alarm()
                        {
                            id = int.Parse(dr["id"].ToString()),
                            Name = dr["Name"].ToString(),
                            State = int.Parse(dr["State"].ToString()),
                            HourEnabled = dr["HourEnabled"].ToString(),
                            HourDisabled = dr["HourDisabled"].ToString(),
                            Monday = int.Parse(dr["Monday"].ToString()),
                            Tuesday = int.Parse(dr["Tuesday"].ToString()),
                            Wednesday = int.Parse(dr["Wednesday"].ToString()),
                            Thursday = int.Parse(dr["Thursday"].ToString()),
                            Friday = int.Parse(dr["Friday"].ToString()),
                            Saturday = int.Parse(dr["Saturday"].ToString()),
                            Sunday = int.Parse(dr["Sunday"].ToString()),
                            Programer = int.Parse(dr["Programer"].ToString()),
                            IP = dr["IP"].ToString()
                        });
                    }
                }
            }
            return olista;
        }
    }
}
