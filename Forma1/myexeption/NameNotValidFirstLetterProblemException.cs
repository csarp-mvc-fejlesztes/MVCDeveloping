using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.myexeption
{
    public class NameNotValidFirstLetterProblemException : Exception
    {
        public NameNotValidFirstLetterProblemException(string message)
           : base(message)
        { }
    }
}
