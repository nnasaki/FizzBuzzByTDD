using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FizzBuzz;
using NUnit.Framework;

namespace FizzBuzzTest
{
    [TestFixture]
    public class FizzBuzzerTest
    {
        [TestCase(1, "1 - 1")]
        [TestCase(2, "2 - 2")]
        [TestCase(3, "3 - Fizz")]
        [TestCase(5, "5 - Buzz")]
        [TestCase(15, "15 - Fizz Buzz")]
        public void SayNextTest(int count, string expected)
        {
            FizzBuzzer obj = new FizzBuzzer();
            string result = null;
            for (int i=0; i < count; i++)
            {
                result = obj.SayNext();
            }
            Assert.AreEqual(expected, result);
        }



    }
}
