using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RomanNumerals.app;

namespace RomanNumerals.tests
{
    [TestFixture]
    public class RomanNumeralConversionTests
    {
        [Test]
        public void Converting_integer_one_to_a_string()
        {
            //Arrange
            int number = 1;
            var numberConverter = new NumberConverter();

            //Act
            var result = numberConverter.Parse(number);

            //Assert
            Assert.AreEqual("I", result);
        }

        [Test]
        public void Converting_integer_five_to_a_string()
        {
            //Arrange
            int number = 5;
            var numberConverter = new NumberConverter();

            //Act
            var result = numberConverter.Parse(number);

            //Assert
            Assert.AreEqual("V", result);
        }

        [Test]
        public void Converting_integer_nine_to_a_string()
        {
            //Arrange
            int number = 9;
            var numberConverter = new NumberConverter();

            //Act
            var result = numberConverter.Parse(number);

            //Assert
            Assert.AreEqual("IX", result);
        }
    }
}
