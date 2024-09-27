using Wordchain.Lib;

namespace Wordchain.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void TestWortHaus()
        {
            // arrange
            string wort = "Haus";

            // act
            bool erg = Checker.Check(wort);

            // assert
            Assert.IsTrue(erg);
        }

        [Test]
        public void TestWortDumm() 
        {
            string wort = "dumm";

            bool erg = Checker.Check(wort);

            Assert.IsTrue(erg);
        }

        [Test]
        public void TestWordsnotallowed([Values("faul","dumm","blöd","gemein")] string wort)
        {
            bool erg = Checker.Check(wort);

            Assert.IsFalse(erg);
        }
    }
}