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

        //public NumarMatricol NumarMatricol { get; internal set; }

        public NumeGeneric numeStudent { get; internal set; }
       // public NumarMatricol numarMatricol { get; internal set;}
        private NumarMatricol numarMatricol;

        public NumarMatricol NumarMatricol
        {
            get { return numarMatricol; }
            set { numarMatricol = value; }
        }
        public Nota NotaFinala {get; internal set;}
      
        internal Student(NumarMatricol numar,NumeGeneric nume)
        {
            this.numeStudent = nume;
            this.numarMatricol = numar;
        }

        internal void notaDisciplina(Nota nota)
        {
            NotaFinala = nota;
        }

        public void afisareStudent()
        {
            Console.WriteLine("Numele studentului este: "+numeStudent.Text);
        }
       

    }
}
