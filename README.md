# Implicit-Types
Although there is nothing wrong with giving a local variable an explicit type, such as **int** or **string**,  I more than often use the **var** keyword to implicitly type a local variable.  When you do this the compiler provides the type at compile time.  It does this by inferring the type of the variable from the expression on the right side of the initialization statement.
You can also use the **var** keyword in **for**, **foreach** and **using** statements.

## Benefits

I feel that using **var** keyword in my code makes it quicker to write and easier to read.

## Restrictions

You can not implicitly type class members (i.e. Fields).
You can only use **var** when declaring and initializing variable in the same statement
You can not initialize with a **null** value
You can not initialize with a method group
You can not initialize with an anonymous function
You can not initialize multiple variables in the same statement

## Local variables examples

### int example

```c#
var j = 17;
```

### string example
```c#
var firstName = "Fred";
```

### List example
```c#
var employees = new List { "Fred Blogs", "James Kane", "Jon Jones"};
```

### anonymous type example
```c#
var employee = new { Name = "Fred Bloggs", Age = 23 };
```

### IEnumerable example

This example is for the type IEnumerable

```c#
var customers = new CustomerQuery().FindAll();

var customersNamedFred = from c in customers
                         where c.FirstName == ""Fred""
                         select c;
```

This example is for the type IEnumerable
```c#
var customers = new List
{
   new { FirstName = "Fred", LastName = "Bloggs" },
   new { FirstName = "Jacon", LastName = "Creaker" }
};

var customersNamedFred = from c in customers
                         where c.FirstName == "Fred"
                         select c;
This example is for the type IEnumerable<‘a> (anonymous type)

var customers = Enumerable.Empty)
                .Select(r => new { FirstName = "Fred", LastName = "Bloggs" }) 
                .ToList();
```

//Example of how to add a customer to the list
```c#
customers.Add(new { FirstName = "Jacon", LastName = "Creaker"});

var customersNamedFred = from c in customers
                         where c.FirstName == "Fred"
                         select c;
```

## for and foreach initialization statement examples


### for initialization statement example


for (var i = 0; i < 100; i++)
{
   Console.WriteLine(i);
}

### foreach initialization statement example


var customers = new List { "Fred Blogs", "James Kane", "Jon Jones"};
foreach (var customer in customers)
{
   Console.WriteLine(customer);
}

### using statement example


using (var httpClient = new HttpClient())
{
   var response = httpClient.GetStringAsync("http://www.google.com").Result;               
}

## Useful links


Implicitly Typed Local Variables (C# Programming Guide)