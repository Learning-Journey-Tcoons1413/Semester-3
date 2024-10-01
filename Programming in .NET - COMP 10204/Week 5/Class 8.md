*Date: October 1st 2024

#### Class is Recorded

 ###### **Polymorphism**
 - Object can take on many forms, which happens at run time. NOT compile time.  

- **Employee Class**
	- Is Abstract 
```cs

```

- **Virtual Method - RESEARCH THIS**
	- Allows for the override of a parent class method when inheriting. We can implement the method if we want to, or we don't have to.

	```cs
		public class Animal 
		{ 
		public virtual void Speak() 
			{ Console.WriteLine("Animal speaks"); } 
		}
		
		public class Dog : Animal 
		{ 
		public override void Speak() 
			{ Console.WriteLine("Woof"); } 
		}
	```

- **Abstract Method**
	- No body, its a method signature. Inheriting objects will define the method. 
	- Inheriting class must declare the method as `override` 

- **Concrete Class**
	- Objects that inherit from abstract classes  


###### **Form Controls**
- **Group Boxes**
	- Looks nice 
	- Mass change properties within the group box for everything 
	- Very helpful for grouping things logically  

-  