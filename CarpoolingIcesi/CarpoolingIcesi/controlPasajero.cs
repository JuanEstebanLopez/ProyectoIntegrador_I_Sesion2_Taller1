using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarpoolingIcesi.Modelo;

namespace CarpoolingIcesi
{
    public partial class controlPasajero : UserControl
    {
        private Carpool carpool;
        private Pasajero pasajero;

        public controlPasajero(Carpool c, Pasajero p)
        {
            InitializeComponent();
            this.carpool = c;
            this.pasajero = p;
            lbPasajeroName.Text = pasajero.Nombre;
            lbPasajeroUbicacion.Text = pasajero.Direccion;
            lbPasajeroTelefono.Text = "Tel: " + pasajero.Telefono;
            lbPasajeroPuntos.Text = "Puntos Carpooling: " + pasajero.PuntosCarpooling;

            foreach (Conductor con in carpool.Conductores()) {
                EstudianteMin control = new EstudianteMin(con);
                lytPasajerosListConduc.Controls.Add(control, 0 ,0);
                control.Dock = DockStyle.Fill;
                EventArgs ev = new EventArgs();
                control.Click += (s, e) => SelectConductor(con); 
            }

        }
         public void SelectConductor(Conductor c)
        {
            lytPasajeroConduElegido.Visible = true;
            lbPasajeroConducElegido.Visible = true;
            EstudianteMin control = new EstudianteMin(c);
            lytPasajeroConduElegido.Controls.Add(control, 0, 0);
            control.Dock = DockStyle.Fill;
        }

        private void controlPasajero_Load(object sender, EventArgs e)
        {

        }

        
        private void btnPasajeroSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            carpool.goHome();
        }
    }
}
