using System;
using NUnit.Framework;
using MathLibrary;

namespace MathLibrary.Test
{
    [TestFixture]
    public class MathOperationsTest
    {
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void SqrtNewtanMetodTest()
        {
            double v = -255; int n = 6;
            Assert.AreEqual(MathOperations.SqrtNewtanMetod(v, n), Math.Pow(v, 1.0 / n), 0.00001);

        }

        [TestCase(15625, 6)]
        [TestCase(160000, 4)]
        [TestCase(255, 2)]
        [TestCase(0, 2)]
        [TestCase(255, 0)]
        public void SqrtNewtanMetodParamTest(double v, int n)
        {
            Assert.AreEqual(MathOperations.SqrtNewtanMetod(v, n), Math.Pow(v, 1.0 / n), 0.00001);
        }

         [TestCase(10, Result = "A")]
         [TestCase(225, Result = "E1")]
         [TestCase(567, Result = "237")]
         [TestCase(159357, Result = "26E7D")]
        public string Format10To16Test(int i)
        {
            return i.Format10to16();
        }

        [TestCase(48, 18, Result = 6)]
        [TestCase(48, 0, Result = 48)]
        [TestCase(72, -96, Result = 24)]
        [TestCase(111, 432, Result = 3)]
        [TestCase(-661, -113, Result = 1)]
        [TestCase(462, 1071, Result = 21)]
        [TestCase(462, 462, Result = 462)]
        public int EuclidAlgorithmTwoParamTest(int a,int b)
        {
            long time;
            return MathOperations.EuclidAlgorithm(a, b, out time);
        }

        [TestCase(-585, 81, -189, Result = 9)]
        [TestCase(111, 432, 93, Result = 3)]
        [TestCase(-661, -113, 54, Result = 1)]
        [TestCase(462, 1071, -42, Result = 21)]
        public int EuclidAlgorithmTheeParamTest(int a, int b, int c)
        {
            long time;
            return MathOperations.EuclidAlgorithm(a, b, c, out time);
        }

        [TestCase(new int[] { 78, 294, 570, 36 }, Result = 6)]
        public int EuclidAlgorithmTheeParamTest(int[] a)
        {
            long time;
            return MathOperations.EuclidAlgorithm(out time, a);
        }

        [TestCase(48, 18, Result = 6)]
        [TestCase(0, 48, Result = 48)]
        [TestCase(-72, 96, Result = 24)]
        [TestCase(1,  -96, Result = 1)]
        [TestCase(72,  1, Result = 1)]
        [TestCase(111, 432, Result = 3)]
        [TestCase(462, 0, Result = 462)]
        [TestCase(462, 462, Result = 462)]
        public int BinaryGCDAlgorithmTwoParamTest(int a, int b)
        {
            long time;
            return MathOperations.BinaryGCDAlgorithm(a, b, out time);
        }
        
        [TestCase(-585, 81, 0, Result = 9)]
        [TestCase(111, -432, 93, Result = 3)]
        [TestCase(661, 13, 54, Result = 1)]
        [TestCase(462, 1071, -42, Result = 21)]
        public int BinaryGCDAlgorithmTheeParamTest(int a, int b, int c)
        {
            long time;
            return MathOperations.BinaryGCDAlgorithm(a, b, c, out time);
        }

        [TestCase(new int[] { 78, 294, 570, 36 }, Result = 6)]
        [TestCase(new int[] { -78, -294, -570, 36 }, Result = 6)]
        public int BinaryGCDAlgorithmTheeParamTest(int[] a)
        {
            long time;
            return MathOperations.BinaryGCDAlgorithm(out time, a);
        }
    }
}