using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.myexeption
{
    class NameNotValidNameIsEmptyException : Exception
    {
        public NameNotValidNameIsEmptyException(string message)
            :base(message)
        { }
    }
}
