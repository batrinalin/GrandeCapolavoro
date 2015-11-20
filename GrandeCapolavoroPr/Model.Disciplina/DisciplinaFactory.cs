using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Disciplina
{
    public class DisciplinaFactory
    {
        public static readonly DisciplinaFactory Instance = new DisciplinaFactory();

        private DisciplinaFactory()
        {

        }
      /* TODO trebuie implementat
       * public Disciplina CreeazaDisciplina(string nume)
        {
            //var disciplina =new Disciplina();
        }
       * */
    }
}
