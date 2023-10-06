using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace NUnitTextProject
{
    
        [TestFixture]
        public class Program
        {
            public int Add(int a, int b)
            {
                return a + b;
            }

            public int Sub(int a, int b)
            {
                return a - b;
            }

            [Test]
            public void BasicAssertion()
            {
                int total1 = Add(1, 2);
                int total2 = Sub(5, 2);

                //Assert.AreEqual(3, total1); // Corrected assertion
                Assert.AreEqual(3, total2); // Corrected assertion
                Assert.That(total1, Is.InRange(5, 8)); // Corrected assertion
            }
        }

        public class ProgramTest
        {
            public static void Main(string[] args)
            {
                Program nUnitClass = new Program();
                nUnitClass.BasicAssertion();
            }
        }
}
