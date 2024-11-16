
*Date: November 12th 2024*

==**TEST QUESTION: HOW TO USE LABMDA EXPRESSIONS WITH SORT FUNCTIONS**==

- Generics 
	- What is it?
		- Lists are generic 
		- `<T>` stand for Template 
		- `findAll<T>(T[] x, T searchItem)`

- Dynamically Change Criteria Within FindAll Function:
	- Passing Functions to Functions
		- Must Define a Delegate (define new data type of type function)

```cs
// delegate: any function that has boolean return and one generic item
delegate bool Match<T>(T item);

//Search Function now takes Function as parameter 
static List<T> findAll<T>(T[] x, Match<T> searchCriteria)
{
	List<T> results = new List<T>();
	foreach(T t in x)
		if (searchCriteria(t))
			results.Add(t);
		return results; b
}
```

- Lambda 
```cs
List<int> matches = findAll(x, (val) => {
	if (val == 10)
		return true;
	return false;
});

// OR

List<int> matches = findAll(x, (val) => val == 10); 

```

- Built in Sort Function 
```cs
matches.Sort(); // Default ascending 

// Sort methods accept lambda expressions 

matches.Sort((i1, i2) => i1 - i2 );
```

- Complex Search Criteria. All Numbers with 7 Or Divided By 7 

```cs
List<int> matches = findAll(x, (val) => {
	if (val % 7 == 0)
		return true;
	foreach(char c in val.ToString())
	{
		if (c == '7')
			return true;
	}
	return false;
})
```