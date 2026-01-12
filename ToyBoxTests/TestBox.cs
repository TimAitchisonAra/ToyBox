using ToyBox;

namespace ToyBoxTests
{
    public class Tests
    {
        private Box theBox;


        [SetUp]
        public void Setup()
        {
            theBox = new Box();
        }

        [Test]
        public void ToyBox_WhenNew_IsEmpty()
        {
            int expected = 0;
            int actual = theBox.GetToyCount();

            Assert.Equals(expected, actual);
        }

        [Test]
        public void ToyBox_AddingToys_IncreasesToyCount()
        {
            int expected = 0;
            int actual = theBox.GetToyCount();

            Assert.Equals(expected, actual);
        }
    }
}
