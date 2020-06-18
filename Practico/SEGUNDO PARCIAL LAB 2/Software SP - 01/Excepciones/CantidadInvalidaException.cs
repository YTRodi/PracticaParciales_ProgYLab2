using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class CantidadInvalidaException : Exception
    {
        #region Constructores
        public CantidadInvalidaException() : base("La cantidad es menor a 1")
        {
        }
        #endregion
    }
}
