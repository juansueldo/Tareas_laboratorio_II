using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_01.Class
{
    public enum Puesto { Caja1, Caja2};
    public class PuestoAtencion
    {
        #region ATRIBUTOS
        private static int _numeroActual;
        private Puesto _puesto;
        #endregion

        #region PROPIEDADES
        public int NumeroActual
        {
            get { return ++PuestoAtencion._numeroActual; }
        }
        #endregion

        #region CONSTRUCTORES
        static PuestoAtencion()
        {
            _numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto) 
        {
            _puesto = puesto;
        }
        #endregion

        #region METODOS
        public bool Atender(Cliente cli)
        {
            bool retorno = false;
            if(cli is not null)
            {
                Thread.Sleep(3000);
                retorno = true;
            }
            return retorno;
        }
        #endregion
    }
}
