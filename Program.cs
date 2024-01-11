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
                Console.Write("radius stromu = ");
                double.TryParse(Console.ReadLine(), out double radius);
                Console.Write("vyska stromu = ");
                double.TryParse(Console.ReadLine(), out double height);
                Console.Write("pocet konarov = ");
                double.TryParse(Console.ReadLine(), out double branchCount);
                Console.Write("typ stromu [T, L, C, B] = ");
                string treeType = Console.ReadLine().Trim().ToUpper();
                Tree tree;
                switch (treeType)
                {
                    case "T":
                        tree = new Tree(radius, height, branchCount);
                        break;
                    case "L":
                        tree = new LeafTree(radius, height, branchCount);
                        break;
                    case "C":
                        tree = new ConiferTree(radius, height, branchCount);
                        break;
                    case "B":
                        tree = new BaobabTree(radius, height, branchCount);
                        break;
                    default:
                        tree = new Tree(radius, height, branchCount);
                        break;
                }
                Console.WriteLine($"\n{tree.GetInfo()}\n");
            } while (true);
        }
    }
}