using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;

namespace Capa_Logica
{
    class CompraControlador 
    {
        public static void AltaCompra(
            
            int IdSouvenir,
            int Cantidad)
        {
            CompraModelo p = new CompraModelo();

            p.IdSouvenir=IdSouvenir;
            p.Cantidad = Cantidad;
          
            p.Guardar();
        }
       

        

        
    }
}
