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
    public partial class ControlLogIn : UserControl
    {
        private Carpool carpool;
        public ControlLogIn(Carpool c)
        {
            InitializeComponent();
            this.carpool = c;
        }

        private void btnLoginLogin_Click(object sender, EventArgs e)
        {
            string cod = txtLoginCodigo.Text;
            string pass = txtLoginContrasena.Text;
            carpool.logIn(cod, pass);
        }

        private void btnLoginRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            carpool.showControl(new ControlSingUp(carpool));
        }
    }
}
