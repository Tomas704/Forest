using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest
{
    internal class DryException : Exception
    {
        string _Message = "Strom vyschol!";
        public DryException()
        {

        }
        public override string Message
        {
            get { return _Message; }
        }
    }
}
