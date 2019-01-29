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
    public partial class ControlConductor : UserControl
    {
        private Carpool carpool;
        private Conductor conductor;
        public ControlConductor(Carpool c, Conductor con)
        {
            InitializeComponent();
            this.carpool = c;
            this.conductor = con;

            lbConductorName.Text = conductor.Nombre;
            lbConductorUbicacion.Text = conductor.Direccion;
            lbConductorTelefono.Text = "Tel: " + conductor.Telefono;
            lbConductorPuntos.Text = "Puntos Carpooling: " + conductor.PuntosCarpooling;
            lbConductorCupo.Text = conductor.Cupo + " Cupos";

            foreach (Pasajero pas in carpool.Pasajeros())
            {
                EstudianteMin control = new EstudianteMin(pas);
                lytConductorListPasajeros.Controls.Add(control, 0, 0);
                control.Dock = DockStyle.Fill;
                EventArgs ev = new EventArgs();
                control.Click += (s, e) => SelectPasajero(pas);
            }

        }

        public void SelectPasajero(Pasajero p)
        {
            conductor.Cupo = conductor.Cupo > 0 ? conductor.Cupo - 1 : conductor.Cupo;
            lbConductorCupo.Text = conductor.Cupo + " Cupos";
            lytConductorPasajerosElegido.Visible = true;
            lblConductorPasajerosSeleccionados.Visible = true;
            EstudianteMin control = new EstudianteMin(p);
            lytConductorPasajerosElegido.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }

        private void btnConductorSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            carpool.goHome();
        }

        private void lblConductorPasajerosSeleccionados_Click(object sender, EventArgs e)
        {

        }
    }
}
