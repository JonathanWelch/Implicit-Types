using System.Collections.Generic;
using NUnit.Framework;

namespace implicit_types
{
    [TestFixture]
    public class ForEachStatementExampleTests
    {
        [Test]
        public void InferredCreationOfAString()
        {
            var customers = new List<string> { "Fred Blogs", "James Kane", "Jon Jones" };
            foreach (var customer in customers)
            {
                Assert.That(customer.GetType(), Is.EqualTo(typeof(string)));
            }
        }
    }
}
