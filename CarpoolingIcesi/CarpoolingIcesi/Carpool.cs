using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarpoolingIcesi.Modelo;

namespace CarpoolingIcesi
{
    public partial class Carpool : Form
    {
        private ModeloCarpooling modelo;

        public Carpool()
        {
            InitializeComponent();
            modelo = new ModeloCarpooling();
            load();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            goHome();
        }

        public void showControl(UserControl control) {
            if (!pnlPrincipal.Contains(control))
            {
                pnlPrincipal.Controls.Add(control);
                control.Dock = DockStyle.Fill;
                control.BringToFront();
            }
            else
            {
                control.BringToFront();
            }
        }
        public void goHome() {
            showControl(new ControlLogIn(this));
        }
        public void logIn(string cod, string pass)
        {

            Estudiante e = modelo.logInCredentials(cod, pass);
           // e = GetEstudiantePrueba(false);
           // modelo.Conductores.Add((Conductor)GetEstudiantePrueba(true));
            //modelo.Conductores.Add((Conductor)GetEstudiantePrueba(true));
            //modelo.Conductores.Add((Conductor)GetEstudiantePrueba(true));
            //modelo.Conductores.Add((Conductor)GetEstudiantePrueba(true));
            // save();
            if (e != null)
            {
                if(e is Pasajero)
                    showControl(new controlPasajero(this, (Pasajero)e));
                else if(e is Conductor)
                    showControl(new ControlConductor(this, (Conductor)e));
            }
            else
            {
                MessageBox.Show("Usuario o contraseña inválida");
            }
            
        }


        public List<Conductor> Conductores() {
            return modelo.Conductores;
        }
        public List<Pasajero> Pasajeros() {
            return modelo.Pasajeros;
        }

        public void save() {
            modelo.save();
        }
        public void load()
        {
            modelo.load();
        }

        public void crearEstdiante(bool isConductor, string codigo, string nombre, string contrasena, string direccion, string telefono, int puntosCarrpooling, int cupo, string placa) {
            Estudiante e = modelo.CrearEstudiante(isConductor, codigo, nombre, contrasena, direccion, telefono, puntosCarrpooling, cupo, placa);
            modelo.AgregarEstudianteYGuardar(e);
            if(e != null)
            {
                if (e is Pasajero)
                    showControl(new controlPasajero(this, (Pasajero)e));
                else if (e is Conductor)
                    showControl(new ControlConductor(this, (Conductor)e));
            }
        }

        public Estudiante GetEstudiantePrueba(bool isConductor) {
            string codigo = "A00241032";
            string nombre = "Juan";
            string contrasena = "124";
            string direccion = "Norte";
            string telefono = "301222705";
            int puntosCarrpooling = 50;
            int cupo =4;
            string placa = "KHB 280";

            if (isConductor)
                return new Conductor(codigo, nombre, contrasena, direccion, telefono, puntosCarrpooling, cupo, placa);
            else
                return new Pasajero(codigo, nombre, contrasena, direccion, telefono, puntosCarrpooling);
        }


    }
}
