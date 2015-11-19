using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Facultate
{   
    public class FacultateRepository :Repositories.Facultate.IFacultateRepository
    {
       
        private static List<Model.Facultate.Facultate> _facultate = new List<Model.Facultate.Facultate>();

        public FacultateRepository()
        {

        }
        public void adaugareFacultate(Model.Facultate.Facultate facultate)
        {
            _facultate.Add(facultate);
        }
    }
}
