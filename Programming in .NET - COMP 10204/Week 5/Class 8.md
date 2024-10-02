*Date: October 1st 2024

#### Class is Recorded

 ###### **Polymorphism**
 - Object can take on many forms, which happens at run time. NOT compile time.  

- **Employee Class**
	- Is Abstract 
```cs

```

- **Virtual Method - 
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

- ######  Key Points:

1. **Declaration**: A method is marked as `virtual` in the base class using the `virtual` keyword. This indicates that it can be overridden.
```cs
public class BaseClass 
{ 
	public virtual void Display() 
	{ 
		Console.WriteLine("Base Class"); 
	} 
}
```
2. **Overriding**: In a derived class, you can override the virtual method using the `override` keyword. This allows the derived class to provide its own implementation.
```cs
public class DerivedClass : BaseClass 
{ 
	public override void Display() 
	{ 
		Console.WriteLine("Derived Class"); 
	} 
}
```
3. **Polymorphism**: When you call a virtual method on an object, the actual method that gets executed is determined at runtime based on the object's actual type, not the type of the reference. This is known as runtime polymorphism.

4. **Abstract Methods**: If a base class method is declared as `abstract`, it must be overridden in any non-abstract derived class. Abstract methods do not have an implementation in the base class.
    
    csharp
    
    Copy code
    
    `public abstract class BaseClass {     public abstract void Display(); }`

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