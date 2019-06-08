using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta1_Optmizar
{
    public class Combinations
    {
        public static void main(String[] args)
        {
            Combinations combinations = new Combinations();
            int n = 5;
            Console.WriteLine("# Ladder's steps: " + n);
            Console.WriteLine("# Step combinations: " + combinations.countCombinations(n, 0));
        }

        public long countCombinations(int n, int level)
        {
            if (n < 0)
            {
                return 0;
            }
            else if (n == 0 && level == 0)
            {
                return 0;
            }
            else if (n == 0 && level > 0)
            {
                return 1;
            }
            return countCombinations(n - 1, level + 1) + countCombinations(n - 2, level + 1)
                    + countCombinations(n - 3, level + 1);
        }
    }
}
