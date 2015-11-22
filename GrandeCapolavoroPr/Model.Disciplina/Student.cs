using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Generic;

namespace Model.Disciplina
{
    public class Student
    {

        private NumeGeneric numeStudent;
        private NumarMatricol numarMatricol;
        private Nota NotaFinala;
      
        internal Student(NumarMatricol numar,NumeGeneric nume)
        {
            this.numeStudent = nume;
            this.numarMatricol = numar;
        }

        public string returnareNumarMaricol()
        {
            return numarMatricol.Numar1;
        }

        internal void notaDisciplina(Nota nota)
        {
            NotaFinala = nota;
        }

        public void afisareNumeStudent()
        {
            Console.WriteLine("Numele studentului este: "+numeStudent.Nume);
        }

        public void afisareNotaStudent()
        {
            Console.WriteLine("Nota studentului este: " + NotaFinala.Valoare);
        }

        public void afisareNumarMatricolStudent()
        {
            Console.WriteLine("Numele studentului este: " + numarMatricol.Numar1);
        }

       

    }
}
