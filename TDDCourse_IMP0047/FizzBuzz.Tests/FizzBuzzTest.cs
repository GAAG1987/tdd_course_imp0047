using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzTest
    {
        [Test]
        public void Answer_InputEqual1_OutputEqual01()
        {
            string expectedOutPut = "1";
            FizzBuzz fb = new FizzBuzz();
            string output = fb.Answer(1);
            Assert.AreEqual(expectedOutPut, output);

        }
    }
}
