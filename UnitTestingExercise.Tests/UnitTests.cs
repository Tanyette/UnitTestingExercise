using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 1, 1, 3)]
        [InlineData(100, 100, 100, 300)]
        [InlineData(10, 10, 10, 30)]
        [InlineData(1, 2, 3, 6)]
        [InlineData(5, 5, 5, 15)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            UnitTestMethods tester = new UnitTestMethods();

            //Act
            var actual = tester.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(100, 25, 75)]
        [InlineData(1, 1, 0)]
        [InlineData(-4, -6, 2)]
        [InlineData(5, 5, 0)]
        public void Subtract(int minuend, int subtrahend, int expected)
        {
            //Arrange
            var tester = new UnitTestMethods();

            //Act
            var actual = tester.Subtract(minuend, subtrahend);


            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(3, 3, 9)]
        [InlineData(4, 4, 16)]
        [InlineData(5, 5, 25)]
        [InlineData(5, 4, 20)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var tester = new UnitTestMethods();

            //Act
            var actual = tester.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(20, 5, 4)]
        [InlineData(4, 2, 2)]
        [InlineData(100, 5, 20)]
        [InlineData(9, 3, 3)]
        public void Divide(int num1, int num2, int expected)
        {
            var tester = new UnitTestMethods();

            var actual = tester.Divide(num1, num2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsCharSymbol()
        {
            //Arrange
            var tester = new UnitTestMethods();
            string symbols = "$^~+<>";


            foreach (char c in symbols)
            {
                //Act
                var isSymbolActual = tester.IsCharSymbol(c);

                //Assert
                Assert.True(isSymbolActual);


            }



        }

        [Fact]
        public void IsCharNotSymbol()
        {
            //Arrange
            var tester = new UnitTestMethods();
            string lettersAndNums = "0123456789abcdefghijklmnopqrstuvwxyz";


            foreach (var character in lettersAndNums)
            {

                bool isSymbolActual = tester.IsCharNotSymbol(character);

                Assert.True(isSymbolActual);


            }


        }

    }   }