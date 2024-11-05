*Date: October 22nd 2024*

Today will be on test. Conceptual question. 
###### Operator Overload 
- Operands determine the operator 
- +
- -
- /
- *
```csharp
public static Point operator +(Point p1, Point p2) 
{ 
	// Create a new Point where X and Y are the sum of the respective components 
	return new Point(p1.X + p2.X, p1.Y + p2.Y); 
}
```
###### Comparison Overload (Must Always Code Out The Opposite Sign!!!!!)
-  <
- >
- ==
- !=

```csharp
    // Overload == operator
    public static bool operator ==(Person p1, Person p2)
    {
        // Check for null to avoid NullReferenceException
        if (ReferenceEquals(p1, null) && ReferenceEquals(p2, null))
            return true;
        if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null))
            return false;
        
        return p1.Age == p2.Age; // Compare by Age
    }
    // Overload != operator
    public static bool operator !=(Person p1, Person p2)
    {
        return !(p1 == p2); // Simply negate the result of == operator
    }

```