﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01.Class
{
    public class Negocio
    {
        #region ATRIBUTOS
        private PuestoAtencion _caja;
        private Queue<Cliente> _clientes;
        private string _nombre;
        #endregion

        #region PROPIEDADES
        public Cliente Cliente
        {
            get { return _clientes.Dequeue(); }
            set { _ = value; }
        }
        #endregion

        #region CONSTRUCTORES
        private Negocio()
        {
            _clientes = new Queue<Cliente>();
            this._caja = new PuestoAtencion(Puesto.Caja1);
        }
        public Negocio(string nombre) :this()
        {
            _nombre = nombre;
        }
        #endregion

        #region SOBRECARGAS
        public static bool operator ==(Negocio n, Cliente c)
        {
            bool retorno = false;
            foreach(Cliente item in n._clientes)
            {
                if(c == item)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }
        public static bool operator +(Negocio n,Cliente c)
        {
            bool retorno = false;
            if(n != c)
            {
                n._clientes.Enqueue(c);
                retorno = true;
            }
            return retorno;
        }
        public static bool operator ~(Negocio n)
        {
            if (n._clientes.Count > 0)
            {
                return n._caja.Atender(n.Cliente);
            }
            return false;
        }
        public int ClientesPendientes
        {
            get { return this._clientes.Count; }
        }
        #endregion
    }
}
