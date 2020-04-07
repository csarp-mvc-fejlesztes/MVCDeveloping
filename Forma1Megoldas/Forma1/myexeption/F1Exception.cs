using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.myexeption
{
    class F1Exception : Exception
    {
        public F1Exception(string message)
            : base(message)
        { }
    }
}
