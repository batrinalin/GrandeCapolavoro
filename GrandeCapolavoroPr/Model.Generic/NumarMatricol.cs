using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Generic
{
    public class NumarMatricol
    {
        private string _numar;

        public string Numar1
        {
            get { return _numar; }
            set { _numar = value; }
        }
        
        public NumarMatricol(string numar)
        {
            this._numar = numar;
        }
    }
}
