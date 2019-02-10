using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalSorting.Model
{
    class Experiment
    { 
        public int[] generate(int a, int b)
        {
            int[] ar = null;
            if (a == 1 && b == 1)
            {
                ar = generateBigArrayAscendenntOrder();
            }
            else if (a == 1 && b == 0)
            {
                ar = generateSmallArrayAscendentOrder();
            }
            else if (a == 2 && b == 1)
            {
                ar = generateBigArrayDescendentOrder();
            }
            else if(a == 2 && b== 0)
            {
                ar = generateSmallArrayDescendentOrder();
            }
            else if(a == 0 && b == 1)
            {
                ar = generateBigArrayRandomOrder();
            }
            else if(a == 0 && b == 0)
            {
                ar = generateSmallArrayRandomOrder();
            }
            return ar;
        }
        public int[] generateBigArrayRandomOrder() {
            Random r = new Random();
            return Enumerable.Repeat(0, 1000000).Select(x => r.Next(1, 1000000)).ToArray();
        }

        public int[] generateSmallArrayRandomOrder()
        {
            Random r = new Random();
            return Enumerable.Repeat(0, 1000).Select(x => r.Next(1, 1000000)).ToArray();
        }

        public int[] generateBigArrayAscendenntOrder()
        {
            return Enumerable.Range(1, 1000000).ToArray();
        }

        public int[] generateSmallArrayAscendentOrder()
        {
            return Enumerable.Range(1, 1000).ToArray();
        }

        public int[] generateBigArrayDescendentOrder()
        {
            return Enumerable.Range(1, 1000000).Reverse().ToArray();
        }

        public int[] generateSmallArrayDescendentOrder()
        {
            return Enumerable.Range(1, 1000).Reverse().ToArray();
        }

    }
}
