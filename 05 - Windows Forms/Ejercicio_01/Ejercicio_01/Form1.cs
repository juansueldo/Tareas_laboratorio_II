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
    public partial class Form1 : Form
    {
        private string _nombre;
        private string _apellido;
        public Form1()
        {
            InitializeComponent();
        }
        public string Nombre
        {
            get
            {
                return this._nombre;
            }
        }
        public string Apellido
        {
            get
            {
                return this._apellido;
            }
        }

        private void btn_saludar_Click(object sender, EventArgs e)
        {
            _nombre = txb_nombre.Text;
            _apellido = txb_apellido.Text;
            if(!(string.IsNullOrEmpty(_nombre)) && !(string.IsNullOrEmpty(_apellido)))
            {
                FormSaludar fs = new FormSaludar();
                fs.SetMensaje = $"Soy {_nombre} {_apellido}";
                fs.ShowDialog();
            }
            
        }
    }
}
