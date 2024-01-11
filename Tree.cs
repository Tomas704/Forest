using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest
{
    internal class Tree
    {
        //public Tree() { }
        //~Tree() { }

        protected class Konar
        {
            public Konar()
            {

            }

            ~Konar()
            {

            }
        }

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
        protected Array konare;
        public double pocetKonarov;

        public Tree()
        {
            age = 0;
            radius = 0;
            height = 0;
            pocetKonarov = 0;
        }

        public Tree(double radius, double height, double pocetKonarov)
        {
            age = 0;
            this.radius = radius;
            this.height = height;
            this.pocetKonarov = pocetKonarov;
        }

        ~Tree()
        {
            Console.WriteLine("The tree was destroyed.");
        }

        public virtual void Growing() //daily
        {
            age += 1 / daysOfYear;
            radius += widthIncrement / daysOfYear;
            height += heightIncrement / daysOfYear;
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
