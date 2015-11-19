using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Generic
{
    public class Nota
    {

        private decimal _valoare;
        public decimal Valoare { get { return _valoare; } }

        public Nota(decimal valoare)
        {
            _valoare = valoare;
        }
    }
}
