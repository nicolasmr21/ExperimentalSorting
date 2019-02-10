using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalSorting.Model
{
    public class Treatment
    {
        public int[] arr { get; set; }
        public Boolean isCounting{ get; set; }

        public Treatment(int[] arr, bool isCounting)
        {
            this.arr = arr;
            this.isCounting = isCounting;
        }

        public void orderArray()
        {
            for (int i = 0; i < 12; i++)
            {
                if (isCounting)
                {
                    TimeSpan stop;
                    TimeSpan start = new TimeSpan(DateTime.Now.Ticks);

                    countingsort(arr);

                    stop = new TimeSpan(DateTime.Now.Ticks);
                    Console.WriteLine(stop.Subtract(start).TotalSeconds);
                }
                else
                {
                    TimeSpan stop;
                    TimeSpan start = new TimeSpan(DateTime.Now.Ticks);

                    radixsort(arr);

                    stop = new TimeSpan(DateTime.Now.Ticks);
                    Console.WriteLine(stop.Subtract(start).TotalSeconds);
                }
            }
        }

            /**
	     * This method is responsible for finding the largest number of the array
	     * @param arr[] of type array.
	     * @param n of type int.
	     * @return mx of type int.
	     */


        public void radixsort(int[] old)
        {
            int i, j;
            int[] tmp = new int[old.Length];
            for (int shift = 31; shift > -1; --shift)
            {
                j = 0;
                for (i = 0; i < old.Length; ++i)
                {
                    bool move = (old[i] << shift) >= 0;
                    if (shift == 0 ? !move : move)  // shift the 0's to old's head
                        old[i - j] = old[i];
                    else                            // move the 1's to tmp
                        tmp[j++] = old[i];
                }
                Array.Copy(tmp, 0, arr, arr.Length - j, j);
            }
        }


        public void countingsort(int[] array)
        {
            int[] aux = new int[array.Length];

            int min = array[0];
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                else if (array[i] > max)
                {
                    max = array[i];

                }
            }

            int[] counts = new int[max - min + 1];

            for (int i = 0; i < array.Length; i++)
            {
                counts[array[i] - min]++;
            }

            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                aux[counts[array[i] - min]--] = array[i];
            }

            arr = aux;
        }
    }
}
