﻿using System;
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
            comando.CommandText = "SELECT id,nombre,descripcion,stock,precio,fecha FROM souvenir ";
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
    }

    //public void Eliminar()
    //{

    //}

    //public void Modificar()
    //{

    //}
}
