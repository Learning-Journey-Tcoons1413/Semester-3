This weeks classes were online

Numbers,
LINQ (Language Independent Query),
Bubble Sort

[Helpful Video](https://mycanvas.mohawkcollege.ca/courses/107650/files/20334825?module_item_id=5684080)
[Helpful Video](https://mycanvas.mohawkcollege.ca/courses/107650/files/20334824?module_item_id=5684081)
[Exercise 3](https://mycanvas.mohawkcollege.ca/courses/107650/pages/w03-exercise?module_item_id=5684082)
###### **Random Number With Array**
```cs
	int[] data = new int[100];
	Random random = new Random(); //Create a Random() object
	for (int i = 0; i < data.Length; i++)
	{
		data[i] = random.Next(1000,4000); 									//.Next() takes two params. Min value is inlcusive and Max value is exclusive
	}
	foreach (var number in data)
	{
		Console.WriteLine(number);
	}
```

###### **Random Numbers With List**
```cs
	const int SIZE = 100;

	List<int> data = new List<int>();   
	Random random = new Random();
	for (int i = 0; i < SIZE; i++)
	{
		data.Add(random.Next(1000,4000));
	}
	foreach (var number in data)
	{
		Console.WriteLine(number);
	}
```

###### **Using LINQ**
```cs
	var results = from x in data where x >= 2000 && x <= 2500 select x;
	foreach (var item in results)
	{
		Console.WriteLine("Value found: "+item);
	}
	//NOTE: var is used to declare the variable type as we do not know what data we will get back! VAR is a runtime data type. Dynamically Typed Keyword
```

###### **Bubble Sort**
```cs
	for (int i = 0; i < data.Count() - 1; i++)
	{
		for (int j = 0; j < data.Count() - 1; j++)
		{
			if (data[j] > data[j + 1])
			{
				int temp = data[j];
				data[j] = data[j + 1];
				data[j + 1] = temp;
			}
		}
	}
```

###### **Filtering and Selecting Certain Things we Want using LINQ**
![[Pasted image 20240917195555.png]]

###### **Comparing Strings and Sorting them Using CompareTo**
![[Pasted image 20240920121533.png]]

