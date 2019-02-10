using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExperimentalSorting.Model;


namespace Test
{
    [TestClass]

    public class ExperimentTest
    {
        Experiment e;
        public void Scene()
        {
            e = new Experiment();
        }
        [TestMethod]
        public void BigArrayRandomTest()
        {
            Scene();
            int [] ar = e.generateBigArrayRandomOrder();
            Assert.AreEqual(ar.Length, 1000000);
        }

        [TestMethod]
        public void SmallArrayRandomTest()
        {
            Scene();
            int[] ar = e.generateSmallArrayRandomOrder();
            Assert.AreEqual(ar.Length, 1000);
        }

        [TestMethod]
        public void BigArrayAscendentTest()
        {
            Scene();
            int[] ar = e.generateBigArrayAscendenntOrder();
            Assert.AreEqual(ar.Length, 1000000);
            for (int i = 0; i < ar.Length-1; i++)
            {
                Assert.IsTrue(ar[i] <= ar[i + 1]);
            }
        }

        [TestMethod]
        public void SmallArrayAscendentTest()
        {
            Scene();
            int[] ar = e.generateSmallArrayAscendentOrder();
            Assert.AreEqual(ar.Length, 1000);
            for (int i = 0; i < ar.Length - 1; i++)
            {
                Assert.IsTrue(ar[i] < ar[i + 1]);
            }
        }

        [TestMethod]
        public void BigArrayDescendentTest()
        {
            Scene();
            int[] ar = e.generateBigArrayDescendentOrder();
            Assert.AreEqual(ar.Length, 1000000);
            for (int i = 0; i < ar.Length - 1; i++)
            {
                Assert.IsTrue(ar[i] > ar[i + 1]);
            }
        }

        [TestMethod]
        public void SmallArrayDescendentTest()
        {
            Scene();
            int[] ar = e.generateSmallArrayDescendentOrder();
            Assert.AreEqual(ar.Length, 1000);
            for (int i = 0; i < ar.Length - 1; i++)
            {
                Assert.IsTrue(ar[i] > ar[i + 1]);
            }
        }
    }
}
