using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04.Class
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor _color;
        private short _tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this._color = color;
            this._tinta = tinta;
        }
        public ConsoleColor GetColor()
        {
            return this._color;
        }
        public short GetTinta(){
            return this._tinta;
        }
        private void SetTinta(short tinta)
        {
            if(this.GetTinta() >= 0 && this.GetTinta() < cantidadTintaMaxima)
            {
                this._tinta += tinta;
            }
        }
        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }
        public bool Pintar(short gasto, out string dibujo)
        {
            bool retorno = false;
            dibujo = "";
            int auxTinta = this.GetTinta();
            if (auxTinta > 0 && gasto <= auxTinta)
            {
                for(int i = 0; i < gasto; i++)
                {
                    Console.Write(dibujo = "*");
                }
                retorno = true;
            }
            return retorno;
        }


    }
}
