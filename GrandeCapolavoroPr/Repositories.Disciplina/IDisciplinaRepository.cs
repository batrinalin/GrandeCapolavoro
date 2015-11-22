using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Disciplina
{
    interface IDisciplinaRepository
    {

        void AdaugaDisciplina(Model.Disciplina.Disciplina disciplina);
        void ActualizeazaDisciplina(Model.Disciplina.Disciplina disciplina);
        void StergereDisciplina(Model.Disciplina.Disciplina disciplina);
        void CautaDisciplina(Model.Disciplina.Disciplina disciplina);
        
    }
}
