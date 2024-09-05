*Date: September 4th 2024*

 Basic Course Information:

| **Instructor**  | Peter Basl                                                                                                 |
| --------------- | ---------------------------------------------------------------------------------------------------------- |
| **Email**       | [peter.basl@mohawkcollege.ca](mailto:peter.basl@mohawkcollege.ca) \| Must use course code in subject field |
| **Course Code** | COMP 10204                                                                                                 |
| **Lecture**     | Tuesday, 2:00pm - 4:00pm, A021                                                                             |
| **Lab**         | Wednesday, 2:00pm - 4:00pm, I202                                                                           |

- We will be programming in C# 
- C# is an OOP language 
- Using .NET 

**Course Evaluation:**
- 5x Assignments (30%) | Non Paper
- Midterm (30%) | Paper
- Final Exam (40%) | Paper
- Just pass everything

**Tools:**
- **Software**: Visual Studio  2022,
- **Textbook**: Visual C#: How to Enterprise

**Circle and Area Example:**

```cs
using System
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp{
	internal class Program{
		static void Main(string[] args){
			Console.Write("Enter a radius: ");
			String input = Console.ReadLine();
			Double radius = Double.Parse(input);
			Double area = Math.PI * (radius * radius);
			Console.WriteLine(area);
		}
	}	
}
```


Make sure to complete [[Programming in .NET - COMP 10204/Week 1/To Do|To Do]]


