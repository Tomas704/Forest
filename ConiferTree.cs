using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest
{
    internal class ConiferTree : Tree
    {
        public ConiferTree(double branchesCount = 0) : base(branchesCount)
        {

        }

        public ConiferTree(double radius, double height, double branchesCount, double[] radiusesOfBranches, double[] heightsOfBranches) : base(radius, height, branchesCount, radiusesOfBranches, heightsOfBranches)
        {

        }

        ~ConiferTree()
        {
            Console.WriteLine("The conifer tree was destroyed.");
        }

        public override void Growing() //daily
        {
            age += 1 / daysOfYear;
            radius += radiusIncrement / daysOfYear;
            height += heightIncrement / daysOfYear;
            foreach (Branch branch in branches)
                branch.Growing();
        }

        public override string GetInfo()
        {
            return $"\n---------- Conifer tree info ----------\nAge = {this.age}\nRadius = {this.radius}\nHeight = {this.height}\nVolume = {this.Volume}\n";
        }
    }
}
