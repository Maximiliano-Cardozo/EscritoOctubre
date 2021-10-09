using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Capa_Datos
{
    public class SouvenirModelo : Modelo
    {

        public int Id;
        public string Nombre;
        public string Descripcion;
        public int Stock;
        public float Precio;
        public DateTime Fecha;


        public DataTable Listar()
        {
            comando.CommandText = "SELECT id,nombre,descripcion,stock,precio,fecha FROM souvenir WHERE estado = 'Activo' ";
            comando.Prepare();

            lector = comando.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(lector);

            return dt;
        }


            public void Guardar()
        {
            PrepararQuery();
            EjecutarQuery();
        }

        private void EjecutarQuery()
        {
            this.comando.ExecuteNonQuery();
        }

        private void PrepararQuery()
        {
            this.comando.CommandText =
                "INSERT INTO souvenir (nombre,descripcion,stock,precio)" +
                "VALUES (@nombre,@descripcion,@stock,@precio)";

            this.comando.Parameters.AddWithValue("@nombre", this.Nombre);
            this.comando.Parameters.AddWithValue("@descripcion", this.Descripcion);
            this.comando.Parameters.AddWithValue("@stock", this.Stock);
            this.comando.Parameters.AddWithValue("@precio", this.Precio);
       
            this.comando.Prepare();
        }
   

    public void Eliminar()
    {
            this.comando.CommandText = "UPDATE souvenir SET Estado = 'Inactivo' WHERE id = @id";
            this.comando.Parameters.AddWithValue("@Id", Id);

            comando.Prepare();
            comando.ExecuteNonQuery();
        }

    public void Modificar() {
            
            
       
           this.comando.CommandText = "UPDATE souvenir SET Nombre = @Nombre," +
            " Stock = @Stock , Precio = @Precio ," +
            " Descripcion = @Descripcion , WHERE id = @id";

           this.comando.Parameters.AddWithValue("@Nombre", Nombre);
           this.comando.Parameters.AddWithValue("@Stock", Stock);
           this.comando.Parameters.AddWithValue("@Precio", Precio);
           this.comando.Parameters.AddWithValue("@Descripcion", Descripcion);
           this.comando.Parameters.AddWithValue("@Id", Id);
      
          comando.Prepare();
          comando.ExecuteNonQuery();
        
     
    }


    }
}

