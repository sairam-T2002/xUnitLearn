using SampleApplication;
using SampleApplication.Interface;
using SampleApplication.Service;

namespace xUnitLearn
{
    public class UnitTest_Theory_
    {
        private ITest _service;
        public UnitTest_Theory_()
        {
            _service = new Service1();
        }

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

        [Theory]
        [InlineData("Sairam")]
        public void TestInterfaceService (string str )
        {
            if(_service is Service1)
            {
                Assert.Equal("Hello "+str,(_service as Service1)?.Greet(str));
            }else if(_service is Service2)
            {
                Assert.Equal("Hello " + str, (_service as Service2)?.Conclude(str));
            }
        }
    }
}
