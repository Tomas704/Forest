using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest
{
    internal class Class1
    {
        public double VypocitajObjem()
        {
            List<double> objemVetvy = new List<double>();
            double priemernyObjem = 0.0;
            for (int i = 0; i < objemVetvy.Count; i++)
                priemernyObjem += objemVetvy[i];
            try
            {
                priemernyObjem /= objemVetvy.Count;  
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            Console.WriteLine("test riadok 1");
            Console.WriteLine("test");
            return priemernyObjem;
        }
    }
}
