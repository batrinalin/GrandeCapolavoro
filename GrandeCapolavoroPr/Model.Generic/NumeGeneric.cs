using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Generic
{
    public class NumeGeneric
    {
        private string _text;
        public string Text { get{return _text;} }

        public NumeGeneric(string text)
        {
            _text = text;
        }
    }
}
