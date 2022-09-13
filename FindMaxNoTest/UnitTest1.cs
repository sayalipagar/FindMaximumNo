using FindMaximumNo;

namespace FindMaxNoTest
{
    public class Tests
    {
        [Test]
        public void GivenMaxFirstNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxNo1 max = new FindMaxNo1();
            int num = max.FindMaxIntNumber(3, 1, 2);
            Assert.AreEqual(num, 3);
        }
        [Test]
        public void GivenMaxSecondNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxNo1 max = new FindMaxNo1();
            int num = max.FindMaxIntNumber(1, 3, 2);
            Assert.AreEqual(num, 3);
        }
        [Test]
        public void GivenMaxThirdNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxNo1 max = new FindMaxNo1();
            int num = max.FindMaxIntNumber(1, 2, 3);
            Assert.AreEqual(num, 3);
        }
    }
}