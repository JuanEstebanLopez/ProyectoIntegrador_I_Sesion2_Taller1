using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarpoolingIcesi
{
    public partial class ControlSingUp : UserControl
    {
        private Carpool carpool;
        private bool isConductor;

        public ControlSingUp(Carpool c)
        {
            InitializeComponent();
            this.carpool = c;
            isConductor = false;
        }

        private void lbLoginCodigo_Click(object sender, EventArgs e)
        {

        }

        private void txtSingupDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ControlSingUp_Load(object sender, EventArgs e)
        {

        }

        private void btnSingupCancelar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            carpool.goHome();
        }

        private void btnSingupCrear_Click(object sender, EventArgs e)
        {

            string codigo = txtSingupCodigo.Text;
            string nombre = txtSingupNombre.Text;
            string contrasena = txtSingupContrasena.Text;
            string direccion = txtSingupDireccion.Text;
            string telefono = txtSingupTelefono.Text;
            int puntosCarrpooling = 50;
            int cupo = 4;
            string placa = isConductor? txtSingupPlaca.Text :"KHB 280";
            carpool.crearEstdiante(isConductor, codigo, nombre, contrasena, direccion, telefono, puntosCarrpooling, cupo, placa);
        }

        private void btnSingupType_Click(object sender, EventArgs e)
        {
            isConductor = !isConductor;
            if (isConductor)
            {
                lbSingupPlaca.Visible = true;
                txtSingupPlaca.Visible = true;
                lblSingupType.Text = "Nuevo Conductor";
                btnSingupType.Text = "Soy Pasajero";
            }
            else
            {
                lbSingupPlaca.Visible = false;
                txtSingupPlaca.Visible = false;
                lblSingupType.Text = "Nuevo Pasajero";
                btnSingupType.Text = "Soy Conductor";
            }
        }
    }
}
