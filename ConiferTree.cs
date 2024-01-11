using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest
{
    internal class ConiferTree : Tree
    {
        public ConiferTree() : base()
        {

        }

        public ConiferTree(double radius, double height, double pocetKonarov) : base(radius, height, pocetKonarov)
        {

        }

        ~ConiferTree()
        {
            Console.WriteLine("The conifer tree was destroyed.");
        }

        public override void Growing() //daily
        {
            age += 1 / daysOfYear;
            radius += widthIncrement / daysOfYear;
            height += heightIncrement / daysOfYear;
        }

        public override string GetInfo()
        {
            return $"\n---------- Conifer tree info ----------\nAge = {this.age}\nRadius = {this.radius}\nHeight = {this.height}\nVolume = {this.Volume}\n";
        }
    }
}
