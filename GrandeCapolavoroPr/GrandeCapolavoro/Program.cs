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

            //Creare 2 studenti (Model.Student Student)
            var student = new Model.Student.Student("101", "201", "batrin", "alin");
            var student2 = new Model.Student.Student("102","202", "batrin", "alex");
            var depozit = new StudentRepository();

           
            
            //Creare disciplina (Model.Disciplina Disciplina)
            var numeDisciplina = new Model.Generic.NumeGeneric("Algebra");
            var idDisciplina = new Model.Generic.IdGeneric("12345");

            string nrMatricol = "123";
            string numeStudent = "alin";
            decimal notaStudent = 1.2m;


            //Creez nota (Model.Generic Nota) si nrMatricol (Model.Generic NumarMatricol pentru a creea entitatea student din Model.Disciplina Student
            var nota = new Nota(notaStudent);
            var matricol = new Model.Generic.NumarMatricol(nrMatricol);
            
            //Creez disciplina (Model.Disciplina Disciplina)
            var disciplina = new Model.Disciplina.Disciplina(numeDisciplina, idDisciplina);
            //Creez studentul (Model.Disciplina Student)
           
            var disc2 =disciplina.CreeazaStudnet(nrMatricol, numeStudent);
            
            disciplina.InscriereStudent(disc2);
            disciplina.NotaFinalaDisciplina(matricol,nota);
            disciplina.afisareListaStudenti();
           

            
            
            

            


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
