using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testare_setGet
{
    class Student
    {

        private numeGeneric nume;

             

        public Student(numeGeneric nume)
        {
            this.nume = nume;
        }

        public void afisareNume()
        {
            Console.WriteLine("\nNumele studentului este: " + nume.NumeGeneric);
        }     
    }
}
