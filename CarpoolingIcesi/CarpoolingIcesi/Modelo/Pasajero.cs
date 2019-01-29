using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpoolingIcesi.Modelo
{
    public class Pasajero : Estudiante
    {
        public Pasajero(string codigo, string nombre, string contrasena, string direccion, string telefono, int puntosCarrpooling) : base(codigo, nombre, contrasena, direccion, telefono, puntosCarrpooling)
        {

        }
    }
}
