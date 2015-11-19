using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelStudent;
using Repositories.Student;
using Model.Disciplina;
using Model.Generic;


namespace GrandeCapolavoro
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Model.Student.Student("101", "201", "batrin", "alin");
            var student2 = new Model.Student.Student("102","202", "batrin", "alin");
            var depozit = new StudentRepository();

            
            //Creare disciplina
            var numeDisciplina = new Model.Generic.NumeGeneric("Algebra");
            var idDisciplina = new Model.Generic.IdGeneric("12345");

            //var numeStudent = new Model.Generic.NumeGeneric("Alin");
            //var nrMatricol = new Model.Generic.NumarMatricol("123");
            string nrMatricol = "123";
            string numeStudent = "alin:";
            //var studentDisciplina = new Model.Disciplina.Student(nrMatricol,numeStudent);
            var disciplina = new Model.Disciplina.Disciplina(numeDisciplina, idDisciplina);
            var disc2 =disciplina.CreeazaStudnet(nrMatricol, numeStudent);
            disciplina.InscriereStudent(disc2);
            disciplina.afisareListaStudenti();
           

            
            
            
            /*
            //Creare nota
            decimal notaStudent = 5.6m;
            var nota = new Model.Generic.Nota(notaStudent);
            var studDisc = new Model.Disciplina.Student(numMatricol, numeGen);
            disciplina.InscriereStudent(studDisc);
            disciplina.adaugaNota(studDisc, nota);

           // Console.WriteLine("Studentul din disciplina are numele: " + studDisc.NumeGeneric + ". \nNumar matricol" + studDisc.NumarMatricol + ". \nNota disciplina: " + studDisc.NotaDisciplina);
           // disci.InscriereStudent()
            */
            


            /*
             * Testare Repository pentru student: adaugareStudent, actualizareStudent, 
             *                                    stergereStudent, afisareStudenti,
             *                                    cautareStudent.
             *                               
            depozit.adaugareStudent(student);
            depozit.adaugareStudent(student2);
            
            depozit.afisareStudenti();

            student2 = new Model.Student.Student("102","202", "matei", "alex");
            depozit.actualizareStudent(student2);
            depozit.afisareStudenti();


            depozit.stergereStudent(student);
            depozit.afisareStudenti();
           */


            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
            

        }
    }
}
