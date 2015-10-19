using System;
using System.Diagnostics;
using NUnit.Framework;

namespace CustomerLibrary.Test
{
    [TestFixture]
    public class CustomerTest
    {
        [Test]
        public void TestMethod()
        {
            Customer c = new Customer("Jeffrey Richter", "+1 (425) 555-0100", 1000000);
            Debug.Write(c);
        }
    }
}