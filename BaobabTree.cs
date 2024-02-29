using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Forest
{
    internal class BaobabTree : LeafTree
    {
        public override double Volume
        {
            get
            {
                double trunkVolume = Math.PI * Math.Pow(radius, 2) * height;
                double branchesVolume = 0;
                for (int i = 0; i < branches.Count; i++)
                    branchesVolume += branches[i].Volume;
                return trunkVolume += branchesVolume;
            }
        }

        public BaobabTree(double branchesCount = 0) : base (branchesCount)
        {

        }

        public BaobabTree(double radius, double height, double branchesCount, double[] radiusesOfBranches, double[] heightsOfBranches) : base(radius, height, branchesCount, radiusesOfBranches, heightsOfBranches)
        {

        }

        ~BaobabTree()
        {
            Console.WriteLine("The baobab was destroyed.");
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
            return $"\n---------- Baobab tree info ----------\nAge = {this.age}\nRadius = {this.radius}\nHeight = {this.height}\nVolume = {this.Volume}\n";
        }
    }
}
