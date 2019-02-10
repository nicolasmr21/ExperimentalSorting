using System;
using ExperimentalSorting.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Test
{
    [TestClass]
    public class TreatmentTest
    {
        int[] ar;
        Treatment t;

        public void Scene1()
        {
            ar = new Experiment().generateBigArrayRandomOrder().Take(98500).ToArray();
            t = new Treatment(ar, false);
        }

        public void Scene2()
        {
            ar = new Experiment().generateBigArrayAscendenntOrder().Take(86200).ToArray();
            t = new Treatment(ar, false);
        }

        public void Scene3()
        {
            ar = new Experiment().generateBigArrayDescendentOrder().Take(54100).ToArray();
            t = new Treatment(ar, false);
        }

        public void Scene4()
        {
            Random r = new Random();
            ar = Enumerable.Repeat(0, 16550600).Select(x => r.Next(1, 16550600)).ToArray();
            t = new Treatment(ar, false);
        }

        public void Scene5()
        {
            ar = Enumerable.Range(1, 12470000).ToArray();
            t = new Treatment(ar, false);
        }

        public void Scene6()
        {
            ar = Enumerable.Range(1, 24300000).Reverse().ToArray();
            t = new Treatment(ar, false);
        }

        public void Scene7()
        {
            ar = new Experiment().generateBigArrayRandomOrder().Take(14900).ToArray();
            t = new Treatment(ar, true);
        }

        public void Scene8()
        {
            ar = new Experiment().generateBigArrayAscendenntOrder().Take(22800).ToArray();
            t = new Treatment(ar, true);
        }

        public void Scene9()
        {
            ar = new Experiment().generateBigArrayDescendentOrder().Take(74000).ToArray();
            t = new Treatment(ar, true);
        }

        public void Scene10()
        {
            Random r = new Random();
            ar = Enumerable.Repeat(0, 8100000).Select(x => r.Next(1, 78100000)).ToArray();
            t = new Treatment(ar, true);
        }

        public void Scene11()
        {
            ar = Enumerable.Range(1, 18900000).ToArray();
            t = new Treatment(ar, true);
        }

        public void Scene12()
        {
            ar = Enumerable.Range(1, 20900000).Reverse().ToArray();
            t = new Treatment(ar, true);
        }
        [TestMethod]
        public void RadixSortTest()
        {
            int[] a = null;
            Scene1();
            t.radixsort(t.arr);
            a = t.arr;
            for(int i = 0; i < a.Length-1; i++)
            {
                Assert.IsTrue(a[i] <= a[i + 1]);
            }

            Scene2();
            t.radixsort(t.arr);
            a = t.arr;
            for (int i = 0; i < a.Length - 1; i++)
            {
                Assert.IsTrue(a[i] <= a[i + 1]);
            }

            Scene3();
            t.radixsort(t.arr);
            a = t.arr;
            for (int i = 0; i < a.Length - 1; i++)
            {
                Assert.IsTrue(a[i] <= a[i + 1]);
            }

            Scene4();
            t.radixsort(t.arr);
            a = t.arr;
            for (int i = 0; i < a.Length - 1; i++)
            {
                Assert.IsTrue(a[i] <= a[i + 1]);
            }

            Scene5();
            t.radixsort(t.arr);
            a = t.arr;
            for (int i = 0; i < a.Length - 1; i++)
            {
                Assert.IsTrue(a[i] <= a[i + 1]);
            }

            Scene6();
            t.radixsort(t.arr);
            a = t.arr;
            for (int i = 0; i < a.Length - 1; i++)
            {
                Assert.IsTrue(a[i] <= a[i + 1]);
            }
        }

        [TestMethod]
        public void CountingSortTest()
        {
            int[] a = null;
            Scene7();
            t.countingsort(t.arr);
            a = t.arr;
            for (int i = 0; i < a.Length - 1; i++)
            {
                Assert.IsTrue(a[i] <= a[i + 1]);
            }

            Scene8();
            t.countingsort(t.arr);
            a = t.arr;
            for (int i = 0; i < a.Length - 1; i++)
            {
                Assert.IsTrue(a[i] <= a[i + 1]);
            }

            Scene9();
            t.countingsort(t.arr);
            a = t.arr;
            for (int i = 0; i < a.Length - 1; i++)
            {
                Assert.IsTrue(a[i] <= a[i + 1]);
            }

            Scene10();
            t.countingsort(t.arr);
            a = t.arr;
            for (int i = 0; i < a.Length - 1; i++)
            {
                Assert.IsTrue(a[i] <= a[i + 1]);
            }

            Scene11();
            t.countingsort(t.arr);
            a = t.arr;
            for (int i = 0; i < a.Length - 1; i++)
            {
                Assert.IsTrue(a[i] <= a[i + 1]);
            }

            Scene12();
            t.countingsort(t.arr);
            a = t.arr;
            for (int i = 0; i < a.Length - 1; i++)
            {
                Assert.IsTrue(a[i] <= a[i + 1]);
            }
        }
    }
}
