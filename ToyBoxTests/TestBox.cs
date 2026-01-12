using NUnit.Framework;
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

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ToyBox_AddingToys_IncreasesToyCount()
        {
            theBox.AddToy("Teddy", "brown", 12.34M);
            theBox.AddToy("Doll", "pink", 34.56M);     

            int expected = 2;
            int actual = theBox.GetToyCount();


            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}
