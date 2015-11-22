using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Generic;

namespace Model.Facultate
{
    public class Personal
    {
        /*In functie de id personalul din cadrul facultatii se pot 
         * produce modificari in aplicatie. De exemplu pentru:
         * id=1 Consideram ca acest personal din cadrul facultatii este un profesor si poate adauga note unui student.
         * id=2 Consideram ca acest personal din cadrul facultatii face parte din secretariat si se poate genera lista de stundeti bursieri.
         * id=3 Consideram ca acest personal din cadrul facultatii face parte din administratia caminelor si poate genera o lista cu cei admini intr-un camin.
         */
        Model.Generic.NumeGeneric nume;
        Model.Generic.NumeGeneric prenume;
        Model.Generic.IdGeneric id;

        public Personal(IdGeneric id, NumeGeneric nume, NumeGeneric prenume)
        {
            this.id = id;
            this.nume = nume;
            this.prenume = prenume;
        }
    }
}
