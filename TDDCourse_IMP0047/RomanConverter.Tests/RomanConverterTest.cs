using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace RomanConverter.Tests
{
    [TestFixture]
    public class RomanConverterTest
    {

        private RomanConverter _RomanConverter;

        [SetUp] //NUnit Debe de ejecutar este método antes de cada prueba
        public void Setup()
        {
            this._RomanConverter = new RomanConverter();
        }

        [Test]
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        

        public void Answer_InputEqualValue_OutputCorrect(int input, string expectedOutPut)
        {
            string output = this._RomanConverter.Answer(input);

            Assert.AreEqual(expectedOutPut, output);
        }

    }
}
