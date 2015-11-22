using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Generic;
using Model.Facultate;

namespace Model.Universitate
{
    public class Universitate
    {
        Model.Generic.NumeGeneric numeleUniversitatii;
        public List<Model.Facultate.Facultate> _listaFacultati;

        public Universitate(Model.Generic.NumeGeneric nume)
        {
            this.numeleUniversitatii = nume;
        }

        public void adaugaFacultate(Model.Facultate.Facultate facul)
        {
            _listaFacultati.Add(facul);
        }
    }
}
