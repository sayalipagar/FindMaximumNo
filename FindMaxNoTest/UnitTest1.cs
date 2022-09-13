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
        [Test]
        public void GivenMaxFloatFirstNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxNo1 max = new FindMaxNo1();
            float num = max.FindMaxfloatNumber(0.3f, 0.1f, 0.2f);
            Assert.AreEqual(0.3f, num);
        }
        [Test]
        public void GivenMaxFloatSecondNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxNo1 max = new FindMaxNo1();
            float num = max.FindMaxfloatNumber(0.1f, 0.3f, 0.2f);
            Assert.AreEqual(0.3f, num);
        }
        [Test]
        public void GivenMaxFloatThirdNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxNo1 max = new FindMaxNo1();
            float num = max.FindMaxfloatNumber(0.1f, 0.1f, 0.3f);
            Assert.AreEqual(0.3f, num);
        }
        [Test]
        public void GivenMaxStringFirst_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxNo1 max = new FindMaxNo1();
            string num = max.FindMaxstringNumber("Peach", "Banana", "Apple");
            Assert.AreEqual("Peach", num);
        }
        [Test]
        public void GivenMaxStringSecond_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxNo1 max = new FindMaxNo1();
            string num = max.FindMaxstringNumber("Banana", "Peach", "Apple");
            Assert.AreEqual("Peach", num);
        }
        [Test]
        public void GivenMaxStringThird_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxNo1 max = new FindMaxNo1();
            string num = max.FindMaxstringNumber("Banana", "Apple", "Peach");
            Assert.AreEqual("Peach", num);
        }
    }
}