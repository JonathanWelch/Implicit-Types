using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace implicit_types
{
    [TestFixture]
    public class LocalVariableExampleTests
    {

        [Test]
        public void InferredCreationOfAnInt()
        {
            var count = 17;

            Assert.That(count.GetType(), Is.EqualTo(typeof (int)));
        }

        [Test]
        public void InferredCreationOfAString()
        {
            var firstName = "Fred";

            Assert.That(firstName.GetType(), Is.EqualTo(typeof (string)));
        }

        [Test]
        public void InferredCreationOfAList()
        {
            var employees = new List<string> { "Fred Blogs", "James Kane", "Jon Jones" };

            Assert.That(employees.GetType(), Is.EqualTo(typeof (List<string>)));
        }


        [Test]
        public void InferredCreationOfAnAnonymousType()
        {
            var employee = new { Name = "Fred Bloggs", Age = 23 };

            Assert.IsTrue(employee.GetType().IsAnonymousType());
        }


        [Test]
        public void InferredCreationOfAnIEnumerableType()
        {
            var customers = new CustomerQuery().FindAll();

            var customersNamedFred = from c in customers
                                     where c.FirstName == "Fred"
                                     select c;

            Assert.IsTrue(customersNamedFred is IEnumerable<Customer>);
        }


        [Test]
        public void InferredCreationOfADifferentIEnumerableType()
        {
            var customers = new List<Customer>
            {
                new Customer {FirstName = "Fred", LastName = "Bloggs"},
                new Customer {FirstName = "Jacon", LastName = "Creaker"}
            };

            var customersNamedFred = from c in customers
                                     where c.FirstName == "Fred"
                                     select c;

            Assert.IsTrue(customersNamedFred is IEnumerable<Customer>);
        }

        [Test]
        public void InferredCreationOfAnIEnumerableAnonymousType()
        {
            var customerTuple = new List<Tuple<string, string>>
            {
                new Tuple<string, string>("Fred", "Bloggs"),
                new Tuple<string, string>("Jacon", "Creaker")
            };

            var customers = customerTuple.Select(t => new
            {
                FirstName = t.Item1,
                LastName = t.Item2
            }).ToList();

            var customersNamedFred = from c in customers
                                     where c.FirstName == "Fred"
                                     select c;

            foreach (var customer in customersNamedFred)
            {
                Assert.IsTrue(customer.GetType().IsAnonymousType());
            }
            
        }

    }
}
