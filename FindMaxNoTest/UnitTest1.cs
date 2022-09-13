using FindMaximumNo;

namespace FindMaxNoTest
{
    public class Tests
    {
       //*****Using Generic***
        [Test]
        public void GivenMaxFirstPosition_WhenAnalized_ShouldReturnMaxNumber()
        {
            Generic<int> max = new Generic<int>(3, 1, 2);
            int num = max.FindMax();
            Assert.AreEqual(num, 3);
        }
        [Test]
        public void GivenMaxSecondPosition_WhenAnalized_ShouldReturnMaxNumber()
        {
            Generic<int> max = new Generic<int>(1, 3, 2);
            int num = max.FindMax();
            Assert.AreEqual(num, 3);
        }
        [Test]
        public void GivenMaxThirdPosition_WhenAnalized_ShouldReturnMaxNumber()
        {
            Generic<int> max = new Generic<int>(1, 2, 3);
            int num = max.FindMax();
            Assert.AreEqual(num, 3);
        }

        [Test]
        public void GivenMaxFirstPositionflaot_WhenAnalized_ShouldReturnMaxNumber()
        {
            Generic<float> max = new Generic<float>(3.1f, 1.2f, 2.0f);
            float num = max.FindMax();
            Assert.AreEqual(num, 3.1f);
        }

        [Test]
        public void GivenMaxSecondPositionflaot_WhenAnalized_ShouldReturnMaxNumber()
        {
            Generic<float> max = new Generic<float>(1.2f, 3.1f, 2.0f);
            float num = max.FindMax();
            Assert.AreEqual(num, 3.1f);
        }
        [Test]
        public void GivenMaxThirdPositionflaot_WhenAnalized_ShouldReturnMaxNumber()
        {
            Generic<float> max = new Generic<float>(1.2f, 2.0f, 3.1f);
            float num = max.FindMax();
            Assert.AreEqual(num, 3.1f);
        }
        [Test]
        public void GivenMaxfirstpositionstring_WhenAnalized_ShouldReturnMaxNumber()
        {
            Generic<string> max = new Generic<string>("Peach", "Apple", "Banana");
            string num = max.FindMax();
            Assert.AreEqual("Peach", num);
        }
        [Test]
        public void GivenMaxSecondpositionstring_WhenAnalized_ShouldReturnMaxNumber()
        {
            Generic<string> max = new Generic<string>("Apple", "Peach", "Banana");
            string num = max.FindMax();
            Assert.AreEqual("Peach", num);
        }
        [Test]
        public void GivenMaxThirdpositionstring_WhenAnalized_ShouldReturnMaxNumber()
        {
            Generic<string> max = new Generic<string>("Banana", "Apple", "Peach");
            string num = max.FindMax();
            Assert.AreEqual("Peach", num);
        }
    }
}
