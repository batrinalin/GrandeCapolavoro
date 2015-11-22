using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Disciplina
{
    class DisciplinaRepository : Repositories.Disciplina.IDisciplinaRepository
    {
        private static List<Model.Disciplina.Disciplina> _discipline = new List<Model.Disciplina.Disciplina>();

        public DisciplinaRepository()
        {

        }

        public void AdaugaDisciplina(Model.Disciplina.Disciplina disciplina)
        {
            _discipline.Add(disciplina);
            Console.WriteLine("O noua disciplina a fostr adaugata.");
        }

        public void ActualizeazaDisciplina(Model.Disciplina.Disciplina disciplina)
        {
            //cod ActualizeazaDisciplina
        }

        public void StergereDisciplina(Model.Disciplina.Disciplina disciplina)
        {
            //cod StergereDisciplina
        }


        public void CautaDisciplina(Model.Disciplina.Disciplina disciplina)
        {
            //cod CautaDisciplina

        }
    }
}
