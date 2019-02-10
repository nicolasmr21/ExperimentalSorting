using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalSorting.Model
{
<<<<<<< HEAD
    class Experiment
=======
    public class Experiment
>>>>>>> 50481a2110f77be0d534a5b8b1dde6b94e4c909b
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
<<<<<<< HEAD
            return Enumerable.Repeat(0, 10000000).Select(x => r.Next(1, 100000000)).ToArray();
=======
            return Enumerable.Repeat(0, 1000000).Select(x => r.Next(1, 1000000)).ToArray();
>>>>>>> 50481a2110f77be0d534a5b8b1dde6b94e4c909b
        }

        public int[] generateSmallArrayRandomOrder()
        {
            Random r = new Random();
<<<<<<< HEAD
            return Enumerable.Repeat(0, 100000).Select(x => r.Next(1, 1000000)).ToArray();
=======
            return Enumerable.Repeat(0, 1000).Select(x => r.Next(1, 1000000)).ToArray();
>>>>>>> 50481a2110f77be0d534a5b8b1dde6b94e4c909b
        }

        public int[] generateBigArrayAscendenntOrder()
        {
<<<<<<< HEAD
            return Enumerable.Range(1, 10000000).ToArray();
=======
            return Enumerable.Range(1, 1000000).ToArray();
>>>>>>> 50481a2110f77be0d534a5b8b1dde6b94e4c909b
        }

        public int[] generateSmallArrayAscendentOrder()
        {
<<<<<<< HEAD
            return Enumerable.Range(1, 100000).ToArray();
=======
            return Enumerable.Range(1, 1000).ToArray();
>>>>>>> 50481a2110f77be0d534a5b8b1dde6b94e4c909b
        }

        public int[] generateBigArrayDescendentOrder()
        {
<<<<<<< HEAD
            return Enumerable.Range(1, 10000000).Reverse().ToArray();
=======
            return Enumerable.Range(1, 1000000).Reverse().ToArray();
>>>>>>> 50481a2110f77be0d534a5b8b1dde6b94e4c909b
        }

        public int[] generateSmallArrayDescendentOrder()
        {
<<<<<<< HEAD
            return Enumerable.Range(1, 100000).Reverse().ToArray();
=======
            return Enumerable.Range(1, 1000).Reverse().ToArray();
>>>>>>> 50481a2110f77be0d534a5b8b1dde6b94e4c909b
        }

    }
}
