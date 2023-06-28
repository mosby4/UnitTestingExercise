using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(5,5,5,15)]
        [InlineData(2, 3, 5, 10)]
        [InlineData(20,76,43,139)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var test = new UnitTestMethods();
          
            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = test.add(num1 , num2 ,num3);

            

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(36,27,9)]
        [InlineData(100,100,0)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var subs = new UnitTestMethods();

            //Act
           var actual = subs.SubtractTest(minuend, subtrhend, expected);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(3,3,9)]
        [InlineData(20,60,1200)]
        [InlineData(32,76,2432)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var multiples = new UnitTestMethods();
            //Act
            var times = multiples.MultiplyTest(num1, num2, expected );
            //Assert
            Assert.Equal(expected, times );
        }

        [Theory]
        [InlineData(99,9,11)]
        [InlineData(400,20,20)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var slash = new UnitTestMethods();
            //Act
            var divided = slash.DivideTest(num1, num2, expected );
            //Assert
            Assert.Equal(expected, divided );
        }

    }
}
