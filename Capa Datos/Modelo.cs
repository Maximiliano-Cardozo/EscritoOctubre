using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Capa_Datos
{
    public class Modelo {
        protected string IpDb;
        protected string NombreDb;
        protected string UsuarioDb;
        protected string PasswordDb;
        protected MySqlConnection conexion;
        protected MySqlCommand comando;
        protected MySqlDataReader lector;

        public Modelo(){
            this.inicializarConexion();
            conexion = new MySqlConnection(
                "server=" + this.IpDb + ";" +
                "userid=" + this.UsuarioDb + ";" +
                "password=" + this.PasswordDb + ";" +
                "database=" + this.NombreDb
            );

            conexion.Open();
            this.comando = new MySqlCommand();
            this.comando.Connection = this.conexion;
            }

        protected void inicializarConexion()
        {
            this.IpDb = "localhost";
            this.NombreDb = "escrito";
            this.UsuarioDb = "root";
            this.PasswordDb = "1492";

        }
    }
}
