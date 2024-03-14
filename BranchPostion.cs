using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest
{
    internal class BranchPostion
    {
        private double x, y, z;

        public BranchPostion(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        ~BranchPostion()
        {

        }
    }
}
