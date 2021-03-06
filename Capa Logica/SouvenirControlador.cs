using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;
namespace Capa_Logica
{
    public static class SouvenirControlador
    {
        public static void AltaSouvenir(
            string Nombre,
            string Descripcion,
            int Stock,
            float Precio)
        {
            SouvenirModelo p = new SouvenirModelo();

            p.Nombre = Nombre;
            p.Descripcion = Descripcion;
            p.Stock = Stock;
            p.Precio = Precio;

            p.Guardar();
        }
        public static void ModificarSouvenir(
            int Id,
            string Nombre,
            string Descripcion,
            int Stock,
            float Precio)
        {

            SouvenirModelo p = new SouvenirModelo();

            p.Id = Id;
            p.Nombre = Nombre;
            p.Descripcion = Descripcion;
            p.Stock = Stock;
            p.Precio = Precio;

            p.Modificar();


        }

        public static DataTable ListarSouvenir()
        {
            SouvenirModelo p = new SouvenirModelo { };
            return p.Listar();
        }
        
        public static void EliminarSouvenir(int Id) { 
            SouvenirModelo p = new SouvenirModelo();
                   
            p.Id=Id;
            p.Eliminar();
        }

    }

}



    

