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
    
        public Disciplina CreeazaDisciplina ( string idGeneric, string nume )
        {

            var disciplina = new Disciplina(new Model.Generic.NumeGeneric(nume),new Model.Generic.IdGeneric(idGeneric));
            return disciplina;
        }
    }
}
