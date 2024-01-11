using System;
using System.Collections.Generic;
using System.Linq;
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
                return Math.PI * Math.Pow(radius, 2) * height;
            }
        }

        public BaobabTree()
        {

        }

        public BaobabTree(double radius, double height, double pocetKonarov) : base(radius, height, pocetKonarov)
        {

        }

        ~BaobabTree()
        {
            Console.WriteLine("The baobab was destroyed.");
        }

        public override void Growing() //daily
        {
            age += 1 / daysOfYear;
            radius += widthIncrement / daysOfYear;
            height += heightIncrement / daysOfYear;
        }

        public override string GetInfo()
        {
            return $"\n---------- Baobab tree info ----------\nAge = {this.age}\nRadius = {this.radius}\nHeight = {this.height}\nVolume = {this.Volume}\n";
        }
    }
}
