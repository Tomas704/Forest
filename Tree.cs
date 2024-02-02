using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest
{
    internal class Tree : IOrganizmus
    {
        //public Tree() { }
        //~Tree() { }

        protected double age; //year
        protected double radius, height;
        protected static double widthIncrement = 0.01; // mm/year
        protected static double heightIncrement = 2.0; // mm/year
        public static double daysOfYear = 365.25;
        public virtual double Volume
        {
            get
            {
                return Math.PI * Math.Pow(radius, 2) * height * 1.0 / 3.0;
            }
        }
        
        public double branchesCount;
        protected List<Branch> branches;

        public Tree()
        {
            age = 0;
            radius = 0;
            height = 0;
            branchesCount = 0;
            branches = new List<Branch>();
        }

        public Tree(double radius, double height, double branchesCount)
        {
            age = 0;
            this.radius = radius;
            this.height = height;
            this.branchesCount = branchesCount;
            this.branches = new List<Branch>();
        }

        ~Tree()
        {
            Console.WriteLine("The tree was destroyed.");
        }

        public virtual void Growing() //daily
        {
            //throw new NotImplementedException();
            age += 1 / daysOfYear;
            radius += widthIncrement / daysOfYear;
            height += heightIncrement / daysOfYear;
            Branch branch1 = new Branch();
            branches.Add(branch1);
        }

        //public double ObjemStromu(int count, double radiusKonara, double heightKonara)
        //{
        //    double V = Math.PI * this.radius * this.radius * this.height * (1.0 / 3.0);
        //    for (int i = 0; i < count; i++)
        //    {
        //        V += Math.PI * radiusKonara * radiusKonara * heightKonara * (1.0 / 3.0);
        //    }
        //    return V;
        //}

        public virtual string GetInfo()
        {
            return $"\n---------- Tree info ----------\nAge = {this.age}\nRadius = {this.radius}\nHeight = {this.height}\nVolume = {this.Volume}\n";
        }
    }
}
