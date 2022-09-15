using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_01
{
    public partial class FormSaludar : Form
    {
        public Form1 formulario;
        public FormSaludar()
        {
            InitializeComponent();
            formulario = new Form1();
            
        }
        public string SetMensaje
        {
            set
            {
                lbl_mensaje.Text = value;
            }
        }
        private void FormSaludar_Load(object sender, EventArgs e)
        {
            //lbl_mensaje.Text = $"Soy {formulario.Nombre} {formulario.Apellido}";
        }
    }
}
