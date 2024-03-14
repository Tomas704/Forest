using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest
{
    internal class OakTree : LeafTree
    {
        public void Grow()
        {
            if (isDry)
            {
                throw new DryException();
            }
        }
    }
}
