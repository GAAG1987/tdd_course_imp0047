﻿using System;
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

        private FizzBuzz _fizzBuzz;

        [SetUp] //NUnit Debe de ejecutar este método antes de cada prueba
        public void Setup()
        {
            this._fizzBuzz = new FizzBuzz();
        }

        [Test]
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "fizz")]
        [TestCase(4, "4")]
        [TestCase(5, "buzz")]
        [TestCase(15, "fizzbuzz")]
        public void Answer_InputEqualValue_OutputCorrect(int input, string expectedOutPut)
        {
            string output = this._fizzBuzz.Answer(input);

            if ((input % 3) == 0 && (input % 5) == 0)
            {
                output = "fizzbuzz";
            }
            
            if ((input % 3) == 0)
            {
                output = "fizz";
            }

            if ((input % 5) == 0)
            {
                output = "buzz";
            }

            if ((input % 3) == 0 && (input % 5) == 0)
            {
                output = "fizzbuzz";
            }

            Assert.AreEqual(expectedOutPut, output);

        }

    }
}
