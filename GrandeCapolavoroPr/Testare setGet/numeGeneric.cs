using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testare_setGet
{
    class numeGeneric
    {
        private string nume;

        public string NumeGeneric
        {
            get { return nume; }
            set { nume = value; }
        }

        public numeGeneric(string nume)
        {
            this.nume = nume;
        }
    }
}
