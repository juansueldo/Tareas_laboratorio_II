using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    public class Ingresante
    {
        private string[] _cursos;
        private string _direccion;
        private int _edad;
        private string _genero;
        private string _nombre;
        private string _pais;

        public Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos, int edad)
        {
            _nombre = nombre;
            _direccion = direccion;
            _genero = genero;
            _pais = pais;
            _cursos = cursos;
            _edad = edad;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"NOMBRE: {_nombre}");
            sb.AppendLine($"DIRECCION: {_direccion}");
            sb.AppendLine($"GENERO: {_genero}");
            sb.AppendLine($"PAIS: {_pais}");
            sb.AppendLine($"CURSOS: {_cursos}");
            sb.AppendLine($"EDAD: {_edad}");

            return sb.ToString();
        }
    }
}
