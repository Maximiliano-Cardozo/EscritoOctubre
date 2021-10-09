using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class CompraModelo : Modelo
    {

        public int Id;
        public int IdProducto;
        public int Cantidad;
        public string Fecha;



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
                "INSERT INTO compra (IdProducto,Cantidad,)" +
                "Values(@IdProducto,@Cantidad)";

            this.comando.Parameters.AddWithValue("@IdProducto", this.IdProducto);
            this.comando.Parameters.AddWithValue("@Cantidad", this.Cantidad);
                    this.comando.Prepare();
        }
    }
}
}
