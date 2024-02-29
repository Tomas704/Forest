using System;
using System.Collections.Generic;

namespace Forest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Forest forest = new Forest();
            //forest.PlantTrees(10);
            //for (int i = 0; i < Tree.daysOfYear; i++) //yearly
            //{
            //    foreach (Tree tree in forest.trees)
            //    {
            //        tree.Growing();
            //    }
            //}
            //foreach (Tree tree in forest.trees)
            //{
            //    Console.WriteLine(tree.GetInfo());
            //}
            Console.WriteLine("Hello world!");
            do
            {
                Console.Write("pocet dni = ");
                double.TryParse(Console.ReadLine(), out double daysCount);
                Console.Write("radius stromu = ");
                double.TryParse(Console.ReadLine(), out double radius);
                Console.Write("vyska stromu = ");
                double.TryParse(Console.ReadLine(), out double height);
                Console.Write("pocet konarov = ");
                double.TryParse(Console.ReadLine(), out double branchesCount);
                double[] radiusesOfBranches = new double[(int)branchesCount];
                double[] heightsOfBranches = new double[(int)branchesCount];
                for (int i = 0; i < branchesCount; i++)
                {
                    Console.Write($"radius {i+1}. konara = ");
                    double.TryParse(Console.ReadLine(), out radiusesOfBranches[i]);
                    Console.Write($"vyska {i + 1}. konara = ");
                    double.TryParse(Console.ReadLine(), out heightsOfBranches[i]);
                }
                Console.Write("typ stromu [T, L, C, B] = ");
                string treeType = Console.ReadLine().Trim().ToUpper();
                Tree tree;
                switch (treeType)
                {
                    case "T":
                        tree = new Tree(radius, height, branchesCount, radiusesOfBranches, heightsOfBranches);
                        break;
                    case "L":
                        tree = new LeafTree(radius, height, branchesCount, radiusesOfBranches, heightsOfBranches);
                        break;
                    case "C":
                        tree = new ConiferTree(radius, height, branchesCount, radiusesOfBranches, heightsOfBranches);
                        break;
                    case "B":
                        tree = new BaobabTree(radius, height, branchesCount, radiusesOfBranches, heightsOfBranches);
                        break;
                    default:
                        tree = new Tree(radius, height, branchesCount, radiusesOfBranches, heightsOfBranches);
                        break;
                }
                for (int i = 0; i < daysCount; i++)
                    tree.Growing();
                Console.WriteLine($"\n{tree.GetInfo()}\n");
            } while (true);
        }
    }
}