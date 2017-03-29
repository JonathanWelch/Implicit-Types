using NUnit.Framework;

namespace implicit_types
{
    [TestFixture]
    public class ForStatementExampleTests
    {
        [Test]
        public void InferredCreationOfAnInt()
        {
            for (var i = 0; i < 100; i++)
            {
                Assert.That(i.GetType(), Is.EqualTo(typeof(int)));
            }
        }
    }
}
