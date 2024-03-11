using AlgoTrening;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace JenkinsTest
{
    public class AlgoTreningTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestFirstAlgo()
        {
            Assert.AreEqual(4, TrainingClass.TrainingMethod());
        }
    }
}