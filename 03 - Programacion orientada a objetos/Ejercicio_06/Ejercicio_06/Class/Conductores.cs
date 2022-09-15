using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06.Class
{
    public class Conductores
    {
        private string _nombre;
        private double _kmDia1;
        private double _kmDia2;
        private double _kmDia3;
        private double _kmDia4;
        private double _kmDia5;
        private double _kmDia6;
        private double _kmDia7;

        public Conductores(string nombre, double kmDia1, double kmDia2, double kmDia3, double kmDia4, double kmDia5, double kmDia6, double kmDia7)
        {
            _nombre = nombre;
            _kmDia1 = kmDia1;
            _kmDia2 = kmDia2;
            _kmDia3 = kmDia3;
            _kmDia4 = kmDia4;
            _kmDia5 = kmDia5;
            _kmDia6 = kmDia6;
            _kmDia7 = kmDia7;
        }
        public string GetNombre()
        {
            return this._nombre;
        }
        public double GetKmSemana()
        {
            return this._kmDia1 + this._kmDia2 + this._kmDia3 + this._kmDia4 + this._kmDia5 + this._kmDia6 + this._kmDia7;
        }
        public string Mostrar()
        {
            return $"El conductor {this.GetNombre ()} hizo {this.GetKmSemana()}km esta semana";
        }
        public static Conductores MasKm(Conductores c1, Conductores c2)
        {
            if(c1.GetKmSemana() > c2.GetKmSemana())
            {
                return c1;

            }
            return c2;
        }
    }
}
