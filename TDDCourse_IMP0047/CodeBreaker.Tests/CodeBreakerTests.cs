using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CodeBreaker.Tests
{
        [TestFixture]
        public class CodeBreakerTests
        {

            public  CodeBreaker _CodeBreaker;

            [SetUp] //NUnit Debe de ejecutar este método antes de cada prueba
            public void Setup()
            {
                this._CodeBreaker = new CodeBreaker();
            }

            [Test]
            
            [TestCase("1234", "4")]
            [TestCase("1233", "falso")]



            public void Answer_InputEqualValue_OutputCorrect(String input, string expectedOutPut)
            {
                string output = this._CodeBreaker.Answer(input);

                Assert.AreEqual(expectedOutPut, output);
            }

        }

}
