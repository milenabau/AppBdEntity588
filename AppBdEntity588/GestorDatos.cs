using AppBdEntity588.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppBdEntity588
{
    class GestorDatos
    {
        public string msj;
        public bool existe(int codigo)
        {
            bool aux = false;
            var db = new tallersena588Context();

            if (db.Estudiantes.Find(codigo) != null)
            {
                aux = true;
                this.msj = "El usuario si existe";
            }
            else
            {
                aux = false;
                this.msj = "No existe el usuario";
            }
            return aux;
        }
    }
}
