using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Student
{
    public class StudentRepository : Repositories.Student.IStudentRepository
    {
        private static List<Model.Student.Student> _student = new List<Model.Student.Student>();

        public StudentRepository()
        {


        }

        public void adaugareStudent(Model.Student.Student student)
        {
            _student.Add(student);
            Console.WriteLine("\n\n~~~A fost apelata functia adaugareStudent.~~~");
            Console.WriteLine("\nA fost ADAUGAT un studentul: \n\tcu cnp-ul: " + student.Cnp +". \n\tNumar matricol: "+student.NumarMatricol+ " .\n\tNumele: " + student.Nume+". \n\tPrenume: "+student.Prenume);

        }

        public void actualizareStudent(Model.Student.Student student)
        {
            Console.WriteLine("\n\n~~~A fost apelata functia actualizareStudent.~~~");
            foreach (Model.Student.Student index in _student)
            {
                if (index.Cnp.Equals(student.Cnp))
                {
                    index.Nume = student.Nume;
                    index.Prenume = student.Prenume;
                    Console.WriteLine("\nA fost ACTUALIZAT studentul: \n\tcu cnp-ul: " + index.Cnp + ". \n\tNumar matricol: " + index.NumarMatricol + " .\n\tNumele: " + index.Nume + ". \n\tPrenume: " + index.Prenume);
                }
            }

        }
        public void stergereStudent(Model.Student.Student student)
        {
            Console.WriteLine("\n\n~~~A fost apelata functia stergereStudent~~~");

            if (_student.Any() == true)
            {
                Console.WriteLine("Lista de studenti nu e goala");
                if (_student.Remove(student))
                {
                    Console.WriteLine("\nA fost STERS studentul: \n\tcu cnp-ul: " + student.Cnp + ". \n\tNumar matricol: " + student.NumarMatricol + " .\n\tNumele: " + student.Nume + ". \n\tPrenume: " + student.Prenume);
                
                }
                else
                {
                    Console.WriteLine("Studentul nu are de unde sa fie sters");
                }
            }
            else
            {
                Console.WriteLine("Lista este goala.");
            }

        }

        public void afisareStudenti()
        {
            Console.WriteLine("\n\n~~S-a apelat functia afisareStudenti~~~");
            foreach (Model.Student.Student index in _student)
                Console.WriteLine("\nA fost AFISAT studentul: \n\tcu cnp-ul: " + index.Cnp + ". \n\tNumar matricol: " + index.NumarMatricol + " .\n\tNumele: " + index.Nume + ". \n\tPrenume: " + index.Prenume);
                
        }

        public void cautaStudent(Model.Student.Student student)
        {
            Console.WriteLine("\n\n~~S-a apelat functia cautaStudent~~~");
            foreach (Model.Student.Student index in _student)
            {
                if (index.Cnp.Equals(student.Cnp))
                {
                    Console.WriteLine("\nA fost GASIT un studentul: \n\tcu cnp-ul: " + index.Cnp + ". \n\tNumar matricol: " + index.NumarMatricol + " .\n\tNumele: " + index.Nume + ". \n\tPrenume: " + index.Prenume);
                
                }
            }
        }

    }
}
