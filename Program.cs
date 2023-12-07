using System;
using System.Collections.Generic;

namespace Forest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forest forest = new Forest();
            forest.PlantTrees(10);
            for (int i = 0; i < Tree.daysOfYear; i++) //yearly
            {
                foreach (Tree tree in forest.trees)
                {
                    tree.Growing();
                }
            }
            foreach (Tree tree in forest.trees)
            {
                Console.WriteLine(tree.GetInfo());
            }
            Console.WriteLine("Hello world!");
            Console.ReadLine();
        }
    }

    class Forest
    {
        public List<Tree> trees;

        public Forest()
        {
            trees = new List<Tree>();
        }

        public void PlantTrees(int count)
        {
            for (int i = 0; i < count; i++)
            {
                trees.Add(new Tree());
            }
        }
    }

    class Tree
    {
        private double age; //year
        private double radius, height;
        private static double widthIncrement = 0.01; // mm/year
        private static double heightIncrement = 2.0; // mm/year
        public static double daysOfYear = 365.25;

        public Tree()
        {
            age = 0;
            radius = 0;
            height = 0;
        }

        ~Tree()
        {
            Console.WriteLine("The tree was destroyed.");
        }

        public void Growing() //daily
        {
            age += 1 / daysOfYear;
            radius += widthIncrement / daysOfYear;
            height += heightIncrement / daysOfYear;
        }

        public string GetInfo()
        {
            return $"---------- Tree info ----------\nAge = {this.age}\nRadius = {this.radius}\nHeight = {this.height}\n";
        }
    }
}