using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Student
{
    interface IStudentRepository
    {
        void adaugareStudent(Model.Student.Student student);
        void actualizareStudent(Model.Student.Student student);
        void stergereStudent(Model.Student.Student student);
        void cautaStudent(Model.Student.Student student);
    }
}
