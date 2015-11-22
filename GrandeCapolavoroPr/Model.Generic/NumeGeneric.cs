using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Generic
{
    public class NumeGeneric
    {
        private string nume;

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
       
        public NumeGeneric(string text)
        {
            nume = text;
        }
    }
}
