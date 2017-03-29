using System.Net.Http;
using NUnit.Framework;

namespace implicit_types
{
    [TestFixture]
    public class UsingStatementExampleTests
    {
        [Test]
        public void InferredCreationOfAHttpClient()
        {
            using (var httpClient = new HttpClient())
            {
                Assert.That(httpClient.GetType(), Is.EqualTo(typeof(HttpClient)));
            }
        }
    }
}
