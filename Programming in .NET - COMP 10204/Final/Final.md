## First Slide:

### a) Setting properties for a described control in an event. (2)

In this part, let's assume you have a button on a Windows Form, and when clicked, it changes the background color of the form.
```csharp
private void changeColorButton_Click(object sender, EventArgs e)
{
    // Setting the BackgroundColor property of the form in an event handler
    this.BackColor = Color.Blue;
}
```

### b) Create and populate a generic collection object and predict the output. (5)

Let's say you're asked to create a generic collection, specifically a `List<int>`, populate it with integers, and then print the output.

```cs
private void populateListButton_Click(object sender, EventArgs e)
{
    // Creating a generic collection (List of integers)
    List<int> numbers = new List<int>();

    // Adding items to the list
    numbers.Add(10);
    numbers.Add(20);
    numbers.Add(30);

    // Predicting the output (printing the contents of the list)
    foreach (var number in numbers)
    {
        Console.WriteLine(number); // Output: 10, 20, 30
    }
}
```

### c) Populate a collection control on a Windows Form app, selecting the requested entry. (3)

For this part, suppose you have a `ListBox` on the Windows Form, and you want to populate it with a collection of employee names. You can also select a specific entry from the list when a button is clicked.

```cs
private void populateListBoxButton_Click(object sender, EventArgs e)
{
    // Creating a collection (List of employees)
    List<string> employees = new List<string> { "John", "Jane", "Bob", "Alice" };

    // Populating the ListBox with employee names
    employeeListBox.Items.Clear();  // Clear existing items
    foreach (var employee in employees)
    {
        employeeListBox.Items.Add(employee);  // Add each employee to the ListBox
    }

    // Selecting the third entry ("Bob") in the ListBox
    employeeListBox.SelectedItem = "Bob";
}
```

### d) Sort a generic collection object using two different custom comparators implementing lambda expressions. (5)

In this example, we'll use a `List<Employee>` class with two different custom comparators for sorting. One comparator will sort by the employee's first name, and another will sort by salary. Both comparators will use lambda expressions.

```cs
class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Salary { get; set; }
}

private void sortEmployeesButton_Click(object sender, EventArgs e)
{
    // Creating a list of Employee objects
    List<Employee> employees = new List<Employee>
    {
        new Employee { FirstName = "John", LastName = "Doe", Salary = 50000 },
        new Employee { FirstName = "Jane", LastName = "Smith", Salary = 60000 },
        new Employee { FirstName = "Alice", LastName = "Johnson", Salary = 70000 }
    };

    // Sorting by FirstName using a custom lambda comparator
    employees.Sort((e1, e2) => e1.FirstName.CompareTo(e2.FirstName));

    // Printing employees sorted by FirstName
    Console.WriteLine("Sorted by First Name:");
    foreach (var employee in employees)
    {
        Console.WriteLine($"{employee.FirstName} {employee.LastName} - {employee.Salary}");
    }

    // Sorting by Salary using another custom lambda comparator
    employees.Sort((e1, e2) => e1.Salary.CompareTo(e2.Salary));

    // Printing employees sorted by Salary
    Console.WriteLine("\nSorted by Salary:");
    foreach (var employee in employees)
    {
        Console.WriteLine($"{employee.FirstName} {employee.LastName} - {employee.Salary}");
    }
}
```

---
## Second Slide

## Third Slide:

## Fourth Slide

