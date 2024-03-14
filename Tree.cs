using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest
{
    abstract class Tree : IOrganizmus
    {
        //public Tree() { }
        //~Tree() { }

        public bool isDry;
        protected double age; //year
        protected double radius, height;
        protected static double radiusIncrement = 0.01 / daysOfYear; // mm/day
        protected static double heightIncrement = 0.02 / daysOfYear; // mm/day
        public static double daysOfYear = 365.25;
        public virtual double Volume
        {
            get
            {
                double trunkVolume = Math.PI * Math.Pow(radius, 2) * height * 1.0 / 3.0;
                double branchesVolume = 0;
                for (int i = 0; i < dictBranches.Keys.Count; i++)
                    branchesVolume += dictBranches.Keys.ElementAt(i).Volume;
                return trunkVolume += branchesVolume;
            }
        }

        public double branchesCount;
        protected Dictionary<Branch, BranchPostion> dictBranches;

        public Tree(double branchesCount = 0)
        {
            this.age = 0;
            this.radius = 0;
            this.height = 0;
            this.branchesCount = branchesCount;
            this.dictBranches = new Dictionary<Branch, BranchPostion>();
            for (int i = 0; i < branchesCount; i++)
                dictBranches.Add(new Branch(), new BranchPostion(1, 1, 1));
        }

        public Tree(double radius, double height, double branchesCount, double[] radiusesOfBranches, double[] heightsOfBranches)
        {
            this.age = 0;
            this.radius = radius;
            this.height = height;
            this.branchesCount = branchesCount;
            this.dictBranches = new Dictionary<Branch, BranchPostion>();
            for (int i = 0; i < branchesCount; i++)
                dictBranches.Add(new Branch(radiusesOfBranches[i], heightsOfBranches[i]), new BranchPostion(1, 1, 1));
        }

        ~Tree()
        {
            Console.WriteLine("The tree was destroyed.");
        }

        public virtual void Grow() //daily
        {
            //throw new NotImplementedException();
            this.age += 1 / daysOfYear;
            this.radius += radiusIncrement;
            this.height += heightIncrement;
            foreach (Branch branch in dictBranches.Keys)
                branch.Grow();
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
