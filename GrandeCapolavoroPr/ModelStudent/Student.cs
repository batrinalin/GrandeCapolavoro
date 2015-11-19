using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Student
{
   public class Student
    {

        private string cnp;

        public string Cnp
        {
            get { return cnp; }
            set { cnp = value; }
        }

        private string numarMatricol;

        public string NumarMatricol
        {
            get { return numarMatricol; }
            set { numarMatricol = value; }
        }

        private string nume;

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        private string prenume;

        public string Prenume
        {
            get { return prenume; }
            set { prenume = value; }
        }

       

        public Student(string cnp, string numarmatricol, string nume, string prenume)
        {
            this.cnp = cnp;
            this.numarMatricol = numarmatricol;
            this.nume = nume;
            this.prenume = prenume;
        }

        

    }
}
