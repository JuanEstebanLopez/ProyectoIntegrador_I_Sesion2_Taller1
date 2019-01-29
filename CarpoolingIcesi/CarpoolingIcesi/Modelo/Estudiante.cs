using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpoolingIcesi.Modelo
{
   public class Estudiante
    {
        /*private string codigo;
        private string nombre;
        private string contrasena;
        private string direccion;
        private string telefono;
        private int puntosCarpooling;*/

        public Estudiante(string codigo, string nombre, string contrasena, string direccion, string telefono, int puntosCarrpooling)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Contrasena = contrasena;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.PuntosCarpooling = puntosCarrpooling;
        }

        public string Codigo { get; set; } //{ get => codigo; set => codigo = value; }
        public string Nombre { get; set; } //{ get => nombre; set => nombre = value; }
        public string Contrasena { get; set; } //{ get => contrasena; set => contrasena = value; }
        public string Direccion { get; set; } //{ get => direccion; set => direccion = value; }
        public string Telefono { get; set; } //{ get => telefono; set => telefono = value; }
        public int PuntosCarpooling { get; set; } //{ get => puntosCarpooling; set => puntosCarpooling = value; }
    }
}
