using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest
{
    internal class Forest
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
                trees.Add(new LeafTree());
            }
        }
    }
}
