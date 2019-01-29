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
    public partial class EstudianteMin : UserControl
    {
        public Estudiante Estudiante { get; set; }

        public EstudianteMin(Estudiante e)
        {
            InitializeComponent();
            this.Estudiante = e;
            lbCondMinNombre.Text = Estudiante.Nombre;
            lbCondMinDire.Text = Estudiante.Direccion;
            if(Estudiante is Conductor)
                lbCondMinCupo.Text = (Estudiante as Conductor).Cupo + " Cupos";
        }

        private void ConductorMin_Load(object sender, EventArgs e)
        {

        }
    }
}
