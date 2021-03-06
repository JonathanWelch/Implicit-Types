# Implicit-Types
Although there is nothing wrong with giving a local variable an explicit type, such as **int** or **string**,  I more than often use the **var** keyword to implicitly type a local variable.  When you do this the compiler provides the type at compile time.  It does this by inferring the type of the variable from the expression on the right side of the initialization statement.
You can also use the **var** keyword in **for**, **foreach** and **using** statements.

## Visual Studio Solution with Examples
In this Repository you can find code examples of Implicit Types in use.  The examples were written as NUnit tests to showcase that the expected type is created.


## Benefits

I feel that using **var** keyword in my code makes it quicker to write and easier to read.  It is certainly my preference when the type is obvious.

## Restrictions

You can not implicitly type class members (i.e. Fields).
You can only use **var** when declaring and initializing variable in the same statement
You can not initialize with a **null** value
You can not initialize with a method group
You can not initialize with an anonymous function
You can not initialize multiple variables in the same statement

## Local variables examples

Listed below are the examples that can be found in the Visual Studio Solution.

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
var employees = new List<string> { "Fred Blogs", "James Kane", "Jon Jones"};
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
var customers = new List<Customer>
{
   new Customer { FirstName = "Fred", LastName = "Bloggs" },
   new Customer { FirstName = "Jacon", LastName = "Creaker" }
};

var customersNamedFred = from c in customers
                         where c.FirstName == "Fred"
                         select c;
```

This example is for the type IEnumerable<‘a> (anonymous type)

```c#
 var customerTuple = new List<Tuple<string, string>>
 {
     new Tuple<string, string>("Fred", "Bloggs"),
     new Tuple<string, string>("Jacon", "Creaker")
 };

 var customers = customerTuple.Select(t => new { 
                              FirstName = t.Item1, 
                              LastName = t.Item2 }).ToList();

 var customersNamedFred = from c in customers
                          where c.FirstName == "Fred"
                          select c;
```

## for and foreach initialization statement examples


### for initialization statement example

```c#
for (var i = 0; i < 100; i++)
{
   Console.WriteLine(i);
}

```

### foreach initialization statement example

```c#
var customers = new List<string> { "Fred Blogs", "James Kane", "Jon Jones"};
foreach (var customer in customers)
{
   Console.WriteLine(customer);
}
```

## using statement example

### using statement example

```c#
using (var httpClient = new HttpClient())
{
   var response = httpClient.GetStringAsync("http://www.google.com").Result;               
}
```

## Useful links

[Implicitly Typed Local Variables (C# Programming Guide)](https://msdn.microsoft.com/en-us/library/bb384061.aspx)