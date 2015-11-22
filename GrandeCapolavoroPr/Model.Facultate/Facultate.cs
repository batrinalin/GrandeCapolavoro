using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Generic;
using Model.Disciplina;

namespace Model.Facultate
{
    public class Facultate
    {
        private string idFacultate { get; set; }
        private  string numeFacultate { get; set;}
        private List<Personal> _personalulFacultatii = new List<Personal>();
        private List<Model.Disciplina.Disciplina> _disciplineFacultate = new List<Model.Disciplina.Disciplina>();
       

        public Facultate(string idFac, string numeFac)
        {
            this.idFacultate = idFac;
            this.numeFacultate = numeFac;
        }

        public void adaugaPersonal(Model.Facultate.Personal personal)
        {
            _personalulFacultatii.Add(personal);
        }





    }
}
