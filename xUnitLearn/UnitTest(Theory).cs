﻿using SampleApplication;

namespace xUnitLearn
{
    public class UnitTest_Theory_
    {
        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        //[InlineData(6)]
        public void MyFirstTheory( int value )
        {
            Assert.True(IsOdd(value));
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        public void MySecondTheory(int value )
        {
            Assert.Equal(IsOdd(value),value%2==1);
        }
        bool IsOdd( int x )
        {
            return x%2 == 1;
        }

        [Theory]
        [InlineData(5)]
        public void TestFactorial(int value )
        {
            Assert.Equal(120,TestClass.Factorial(value));
        }
    }
}