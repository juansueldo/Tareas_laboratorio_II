using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_03
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int> diccionario;
        private List<string> palabras;
        public Form1()
        {
            InitializeComponent();
            diccionario = new Dictionary<string, int>();
            palabras = new List<string>();
        }
        private void Contador(string texto)
        {
            
            if (!(string.IsNullOrEmpty(texto)))
            {
                char[] separar = { ' ', ',', '.', ':', '\t' };
                texto = texto.ToLower();
                palabras.AddRange(texto.Split(separar, StringSplitOptions.RemoveEmptyEntries));
                foreach (string palabra in palabras)
                {
                    if (!diccionario.ContainsKey(palabra) && palabra != " ")
                    {
                        diccionario.Add(palabra, 1);
                    }
                    else
                    {
                        diccionario[palabra] += 1;
                    }
                }
                List<KeyValuePair<string, int>> listaDePalabras = diccionario.ToList();
                listaDePalabras.Sort(OrdenarLista);

                MessageBox.Show(Mostrar(listaDePalabras));
            }
            else
            {
                MessageBox.Show("No se ingresaron palabras");
            }
            //string[] palabras = texto.Split(" ");
            
        }
        private string Mostrar(List<KeyValuePair<string,int>> aux)
        {
            StringBuilder sb = new StringBuilder();

             foreach (KeyValuePair<string, int> item in aux)
             {
                  sb.AppendLine($"Palabra ingresada: {item.Key} Repeticiones: {item.Value}");
             }
            
            return sb.ToString();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            Contador(this.rtb_palabras.Text);
        }
        private int OrdenarLista(KeyValuePair<string,int> e1, KeyValuePair<string, int> e2)
        {
            return e1.Value - e2.Value;
        }
    }
}
