using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Facultate
{
    public class Facultate
    {
        public string idFacultate { get; set; }
        public  string numeFacultate { get; set;}
       

        public Facultate(string idFac, string numeFac)
        {
            this.idFacultate = idFac;
            this.numeFacultate = numeFac;
        }
        






    }
}
