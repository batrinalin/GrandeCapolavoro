using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Universitate
{
    interface IUniversitateRepository
    {
        void adaugareUniversitate(Model.Universitate.Universitate universitate);
        void actualizareUniversitate(Model.Universitate.Universitate universitate);
        void stergereUniversitate(Model.Universitate.Universitate universitate);
        void cautaUniversitate(Model.Universitate.Universitate universitate);
    }
}
