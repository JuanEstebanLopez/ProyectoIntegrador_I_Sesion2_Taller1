using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Newtonsoft.Json;

namespace CarpoolingIcesi.Modelo
{
    class ModeloCarpooling
    {
        private List<Conductor> conductores;
        private List<Pasajero> pasajeros;

        public List<Conductor> Conductores { get => conductores; set => conductores = value; }
        public List<Pasajero> Pasajeros { get => pasajeros; set => pasajeros = value; }

        public ModeloCarpooling()
        {
            Conductores = new List<Conductor>();
            Pasajeros = new List<Pasajero>();
            Cargar();
        }

        public void Cargar() {

        }

        public Estudiante logInCredentials(string cod, string pass) {
            foreach (Estudiante e in Conductores) {
                if (cod == e.Codigo)
                    if (pass == e.Contrasena) return e;
            }
            foreach (Estudiante e in Pasajeros)
            {
                if (cod == e.Codigo)
                    if(pass == e.Contrasena) return e;
            }
            return null;
        }

        public Estudiante CrearEstudiante(bool isConductor, string codigo, string nombre, string contrasena, string direccion, string telefono, int puntosCarrpooling, int cupo, string placa)
        {
            if (isConductor)
                return new Conductor(codigo, nombre, contrasena, direccion, telefono, puntosCarrpooling, cupo, placa);
            else
                return new Pasajero(codigo, nombre, contrasena, direccion, telefono, puntosCarrpooling);
        }

        public void AgregarEstudianteYGuardar(Estudiante e) {
            if (e is Conductor)
                Conductores.Add(e as Conductor);
            else if (e is Pasajero)
                Pasajeros.Add(e as Pasajero);
            save();
        }


        public void save() {
            string pas = JsonConvert.SerializeObject(pasajeros);
            escritura("pasajeros", pas);
            string con = JsonConvert.SerializeObject(conductores);
            escritura("conductores", con);
        }

        public void load()
        {
            // string con = lectura("conductores");
            // con = @"[{'Cupo':4,'Placa':'KHB 280','Codigo':'A00241032','Nombre':'Juan','Contrasena':'124','Direccion':'Norte','Telefono':'301222705','PuntosCarpooling':50},{'Cupo':4,'Placa':'KHB 280','Codigo':'A00241032','Nombre':'Juan','Contrasena':'124','Direccion':'Norte','Telefono':'301222705','PuntosCarpooling':50},{'Cupo':4,'Placa':'KHB 280','Codigo':'A00241032','Nombre':'Pedro','Contrasena':'124','Direccion':'Norte','Telefono':'301222705','PuntosCarpooling':50}]";
            // List<Conductor> conduc = JsonConvert.DeserializeObject<List<Conductor>>(con);

            List<Conductor> conduc = JsonConvert.DeserializeObject<List<Conductor>>(File.ReadAllText(@"..\\..\\conductores.txt"));
            Conductores = conduc;


            // string pas = @"[{'Codigo':'A00241022','Nombre':'Esteban','Contrasena':'124','Direccion':'Sur','Telefono':'301222705','PuntosCarpooling':50}]"; // lectura("pasajeros");
            // List<Pasajero> passa = JsonConvert.DeserializeObject<List<Pasajero>>(pas);

            List<Pasajero> passa  = JsonConvert.DeserializeObject<List<Pasajero>>(File.ReadAllText(@"..\\..\\pasajeros.txt"));
            Pasajeros = passa;
        }

        public static string lectura(string filename)
        {
            String line = "";
            try
            {
                StreamReader sr = new StreamReader("..\\..\\" + filename + ".txt");

                line = "";

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }

                sr.Close();
                //Console.ReadLine();

                Thread.Sleep(4000);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return line;
        }

        public static void escritura(string filename, string data)
        {
            try
            {                
                StreamWriter sw = new StreamWriter("..\\..\\"+filename+".txt", false);
                sw.WriteLine(data);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

    }
}
