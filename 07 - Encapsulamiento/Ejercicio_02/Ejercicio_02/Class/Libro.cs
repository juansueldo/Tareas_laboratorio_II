using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02.Class
{
    internal class Libro
    {
        #region ATRIBUTOS
        private List<string> _paginas;
        #endregion

        #region CONSTRUCTORES
        public Libro()
        {
            _paginas = new List<string>();
        }
        #endregion

        #region PROPIEDADES
        public string this[int i]
        {
            get
            {
                if(i > 0 && i < _paginas.Count)
                {
                    return _paginas[i];
                }
                return " ";
            }
            set
            {
                if(i > _paginas.Count)
                {
                    _paginas.Add(value);
                }
                else if(i >= 0)
                {
                    _paginas.Insert(i, value);
                }
            }
        }
        #endregion
    }
}
