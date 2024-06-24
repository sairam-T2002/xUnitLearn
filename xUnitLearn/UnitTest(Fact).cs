namespace xUnitLearn
{
    public class UnitTest_Fact_
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(3+2, Add(3,2));
        }
        [Fact]
        public void FailingTest()
        {
            Assert.Equal(10, Add(5, 5));
        }
        int Add (params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}