using System;
using System.Collections.Generic;
using System.Linq;

namespace implicit_types
{
    public class LocalVariables
    {
        public void Int()
        {
            var j = 17;
        }

        public void String()
        {
            var firstName = "Fred";
        }

        public void List()
        {
            var employees = new List<string> { "Fred Blogs", "James Kane", "Jon Jones" };
        }

        public void AnonymousType()
        {
            var employee = new { Name = "Fred Bloggs", Age = 23 };
        }

        public void IEnumerableExampleOne()
        {
            var customers = new CustomerQuery().FindAll();

            var customersNamedFred = from c in customers
                                     where c.FirstName == "Fred"
                                     select c;
        }

        public void IEnumerableExampleTwo()
        {
            var customers = new List<Customer>
            {
                new Customer {FirstName = "Fred", LastName = "Bloggs"},
                new Customer {FirstName = "Jacon", LastName = "Creaker"}
            };

            var customersNamedFred = from c in customers
                where c.FirstName == "Fred"
                select c;
        }

        public void IEnumerableAnonymousType()
        {
            var customerTuple = new List<Tuple<string, string>>
            {
                new Tuple<string, string>("Fred", "Bloggs"),
                new Tuple<string, string>("Jacon", "Creaker")
            };

            var customers = customerTuple.Select(t => new
            {
                FirstName = t.Item1, LastName = t.Item2
            }).ToList();

            var customersNamedFred = from c in customers
                                     where c.FirstName == "Fred"
                                     select c;


            //var customers = Enumerable.Empty<string>()
            //    .Select(r => new { FirstName = "Fred", LastName = "Bloggs" })
            //    .ToList();

            ////Example of how to add a customer to the list
            //customers.Add(new { FirstName = "Jacon", LastName = "Creaker" });

            //var customersNamedFred = from c in customers
            //                         where c.FirstName == "Fred"
            //                         select c;
        }


    }
}
