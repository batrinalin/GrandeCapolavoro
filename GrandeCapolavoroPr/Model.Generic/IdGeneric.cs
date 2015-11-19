using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Generic
{
    public class IdGeneric
    {
        private string idGeneric;

        public string IdGeneric1
        {
            get { return idGeneric; }
            set { idGeneric = value; }
        }

        public IdGeneric(string id)
        {
            this.idGeneric = id;
        }
    }
}
