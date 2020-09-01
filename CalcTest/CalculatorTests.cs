using System;
using NUnit.Framework;
using CalcLibrary;
using MathLibrary;

namespace CalcTest
{
    [TestFixture]


    public class CalculatorTests
    {
        int i, j;
        float expected;
        [SetUp]
        public void setup()
        {
            i = 5;
            j = 4;
        }
        [TestCase(2, 3, 5)]
        [TestCase(2, 3, 6)]
        public void For_Add(int a, int b, int expected)
        {
            var obj1 = new Calculator();

            int actual = obj1.Addition(a, b);

            Assert.AreEqual(expected, actual);
        }
        [TestCase]
        public void For_Subs()
        {
            var obj1 = new Calculator();

            float actual = obj1.Substraction(i, j);
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(5.0, 2.5)]
        public void For_Subs_withCases(float a, float b)
        {
            var obj1 = new Calculator();

            float actual = obj1.Substraction(a, b);
            float expected = 2.5f;

            Assert.AreEqual(expected, actual);
        }
        [TestCase]
        public void For_Multiply()
        {
            var obj1 = new Calculator();

            int actual = obj1.multiplication(i, j);
            int expected = 20;

            Assert.AreEqual(expected, actual);
        }
        [TestCase(20, 4, 5)]
        public void For_Divide_withCases(int a, int b, int expected)
        {
            var obj1 = new Calculator();

            float actual = obj1.Division(a, b);

            Assert.AreEqual(expected, actual);
        }


        [TestCase]
        public void For_Divide()
        {
            var obj1 = new Calculator();

            float actual = obj1.Division(i, j);
            float expected = 1.25f;

            Assert.AreEqual(expected, actual);
        }

        [TestCase]
        public void For_DivideByZero()
        {
            var obj1 = new Calculator();

            try
            {
                obj1.Division(4, 0);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("divide by zero is not applicable");

            }
        }
    }
    [TestFixture]
    public class MathTest
    {
        [TestCase (2,3,5)]
        [TestCase (3,3,6)]
        public void Test_Add_And_clear(int a, int b, int expected)
        {
            var obj2 = new Class1();

            obj2.ADDition(a,b);
            int actual = obj2.GetResult;

            Assert.AreEqual(expected, actual);

            obj2.AllClear();
            actual = obj2.GetResult;


            Assert.AreEqual(0, actual);
        }
    }
        
       
    
}
