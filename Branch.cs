using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest
{
    internal class Branch : IOrganizmus
    {
        protected double radius, height;
        private static double radiusIncrement = 0.01; // mm/year
        private static double heightIncrement = 2.0; // mm/year
        public double Volume
        {
            get
            {
                return Math.PI * Math.Pow(this.radius, 2) * this.height * 1.0 / 3.0;
            }
        }

        public Branch()
        {
            this.radius = 0;
            this.height = 0;
        }

        public Branch(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        ~Branch()
        {
            Console.WriteLine("The branch was destroyed.");
        }

        public void Grow() //daily
        {
            radius += radiusIncrement / Tree.daysOfYear;
            height += heightIncrement / Tree.daysOfYear;
        }
    }
}
