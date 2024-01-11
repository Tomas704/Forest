using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest
{
    internal class LeafTree : Tree
    {
        public LeafTree() : base()
        {

        }

        public LeafTree(double radius, double height, double pocetKonarov) : base(radius, height, pocetKonarov)
        {

        }

        ~LeafTree()
        {
            Console.WriteLine("The leaf tree was destroyed.");
        }

        public override void Growing() //daily
        {
            age += 1 / daysOfYear;
            radius += widthIncrement / daysOfYear;
            height += heightIncrement / daysOfYear;
        }

        public override string GetInfo()
        {
            return $"\n---------- Leaf tree info ----------\nAge = {this.age}\nRadius = {this.radius}\nHeight = {this.height}\nVolume = {this.Volume}\n";
        }
    }
}
