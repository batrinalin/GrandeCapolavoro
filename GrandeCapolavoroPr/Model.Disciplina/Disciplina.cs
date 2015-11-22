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
            Console.WriteLine("~~Se apeleaza InscriereStudent -dinsicplina~~");
            _studentiInscrisi.Add(student);
        }

        public void afisareListaStudenti()
        {
            Console.WriteLine("~~Se apeleaza afisareListaStudenti -dinsicplina~~");
            foreach (Model.Disciplina.Student index in _studentiInscrisi)
            {
                index.afisareNumeStudent();
                index.afisareNumarMatricolStudent();
                index.afisareNotaStudent();
            }
        }

        public void NotaFinalaDisciplina(Model.Generic.NumarMatricol numarMatricol, Model.Generic.Nota nota)
        {
            foreach (Model.Disciplina.Student index in _studentiInscrisi)
            {
                var nrMatric = index.returnareNumarMaricol();

                if (nrMatric.Equals(numarMatricol.Numar1))
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
