using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CarpoolingIcesi.Modelo
{
    public class Conductor : Estudiante
    {
        /*private int cupo;
        private string placa;*/

        public Conductor(string codigo, string nombre, string contrasena, string direccion, string telefono, int puntosCarrpooling, int cupo, string placa) : base(codigo, nombre, contrasena, direccion, telefono, puntosCarrpooling)
        {
            this.Cupo = cupo;
            this.Placa = placa;
        }

        public int Cupo { get; set; } //{ get => cupo; set => cupo = value; }
        public string Placa { get; set; } //{ get => placa; set => placa = value; }
    }
}
