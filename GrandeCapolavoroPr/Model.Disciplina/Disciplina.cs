using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Generic;
using System.Collections.ObjectModel;

namespace Model.Disciplina
{
    public class Disciplina
    {
        public Model.Generic.NumeGeneric nume { get; internal set; }
        public Model.Generic.IdGeneric id;

        private List<Student> _studentiInscrisi;
        public ReadOnlyCollection<Student> StudentiInscrisi { get { return _studentiInscrisi.AsReadOnly(); } }

        //trebuie pus internal: public Disciplina
        public Disciplina(Model.Generic.NumeGeneric nume, Model.Generic.IdGeneric id)
        {
            Console.WriteLine("\n~~~S-a creeat o disciplina.~~~");
            this.nume = nume;
            this.id = id;
            _studentiInscrisi = new List<Student>(50);
            
        }


       public void InscriereStudent(Student student)
        {
            Console.WriteLine("\nS-a inscris in lista studentul cu numele: ");
            student.afisareStudent();
         //  Conso ". Si numar matricol: " + student.NumarMatricol);
            _studentiInscrisi.Add(student);
        }

       public void afisareListaStudenti()
       {
           foreach (Model.Disciplina.Student index in _studentiInscrisi)
           {
               Console.WriteLine("\nNume student: " + index.numeStudent + ". Numar matricol: " + index.NumarMatricol);
           }
       }
       public void NotaFinalaDisciplina(Model.Generic.NumarMatricol numarMatricol,Model.Generic.Nota nota)
       {
           foreach(Model.Disciplina.Student index in _studentiInscrisi)
           {
               if (index.NumarMatricol.Equals(numarMatricol))
               {
                   index.notaDisciplina(nota);
               }
           }
       }

       public Student CreeazaStudnet(string numarMatricol, string numeStudent)
       {
           
           var student = new Student(new NumarMatricol(numarMatricol), new NumeGeneric(numeStudent));
           //Console.WriteLine("\nS-a creeat studentul cu numele: " + student.numeStudent + " si numarul matricol: " + student.numarMatricol);

           return student;
       }

    }
}
