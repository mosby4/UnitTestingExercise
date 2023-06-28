using System;
namespace UnitTestingExercise
{
	public class UnitTestMethods
	{
		public UnitTestMethods()
		{
		}

        public object add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public object DivideTest(int num1, int num2, int expected)
        {
            return num1 / num2;
        }

        public object MultiplyTest(int num1, int num2, int expected)
        {
            return num1 * num2;
        }

        public object SubtractTest(int minuend, int subtrhend, int expected)
        {
            return minuend - subtrhend;
        }
    }
}

