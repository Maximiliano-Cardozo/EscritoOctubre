using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Logica
{
    public static class ProductoControlador
    {
        public static void AltaProducto(
            string Nombre,
            string Descripcion,
            int Stock,
            float Precio)
        {
            ProductoModelo p= new ProductoModelo();

            p.Nombre = Nombre;
            p.Descripcion = Descripcion;
            p.Stock = Stock;
            p.Precio = Precio;

            p.Guardar();
        }
    }
}
