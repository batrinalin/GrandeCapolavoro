using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testare_setGet
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeStudent = new numeGeneric("alin");
            var student = new Student(numeStudent);

            student.afisareNume();
            Console.ReadLine();
        }
    }
}
