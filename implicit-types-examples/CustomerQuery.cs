using System.Collections.Generic;

namespace implicit_types
{
    public class CustomerQuery
    {
        public IEnumerable<Customer> FindAll()
        {
            return new List<Customer>
            {
                new Customer { FirstName = "Fred", LastName = "Bloggs"},
                new Customer { FirstName = "Jon", LastName = "Welch" },
                new Customer { FirstName = "Peter", LastName = "Panther" }
            };
        }
    }
}