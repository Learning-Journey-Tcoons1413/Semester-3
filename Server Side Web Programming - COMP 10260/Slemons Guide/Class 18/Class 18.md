**Classes & Objects in PHP**

**Important Considerations:**

1. Constructor syntax:
```php
	class Chef {
	    protected $name;
	    protected $age;
	
	    public function __construct($name, $age) {
	        $this->name = $name;
	        $this->age = $age;
	    }
	
	    // Define the __toString() method
	    public function __toString() {
	        return "Chef: {$this->name}, Age: {$this->age}";
	    }
	}
	
	$chef = new Chef("Gordon Ramsay", 50);
	echo $chef;  // A call to  __toString(), output: "Chef: Gordon Ramsay, Age: 50"
```

2. PHP can only have one constructor, i.e. no overloads allowed! But, you can still have a default constructor if you make it:
```php
class Chef {
    protected $name;
    protected $age;

    // Default constructor with optional parameters
    public function __construct($name = "Unknown Chef", $age = 30) {
        $this->name = $name;
        $this->age = $age;
    }

    public function getInfo() {
        return "Chef: {$this->name}, Age: {$this->age}";
    }
}

// Creating instances with and without arguments
$chef1 = new Chef("Gordon Ramsay", 50);
echo $chef1->getInfo();  // Output: Chef: Gordon Ramsay, Age: 50

$chef2 = new Chef();
echo $chef2->getInfo();   // Output: Chef: Unknown Chef, Age: 30
```

3. Getters & Setters ... note the use of braces echo {$this->getAge()} which are used to remove ambiguity.
```php
class Chef {
    protected $name;
    protected $age;

    // Constructor with optional parameters
    public function __construct($name = "Unknown Chef", $age = 30) {
        $this->name = $name;
        $this->age = $age;
    }

    // Getter for name
    public function getName() {
        return $this->name;
    }

    // Setter for name
    public function setName($name) {
        $this->name = $name;
    }

    // Getter for age
    public function getAge() {
        return $this->age;
    }

    // Setter for age
    public function setAge($age) {
        if ($age > 0) { // Simple validation to ensure age is positive
            $this->age = $age;
        } else {
            echo "Age must be positive.<br>";
        }
    }

    public function getInfo() {
        return "Chef: {$this->name}, Age: {$this->age}";
    }
}

// Using the getters and setters
$chef = new Chef();
echo $chef->getInfo() . "<br>";  // Output: Chef: Unknown Chef, Age: 30

// Set name and age using setters
$chef->setName("Gordon Ramsay");
$chef->setAge(50);

// Get the updated properties
echo "Name: " . $chef->getName() . "<br>";  // Output: Name: Gordon Ramsay
echo "Age: " . $chef->getAge() . "<br>";    // Output: Age: 50

// Display full information
echo $chef->getInfo();  // Output: Chef: Gordon Ramsay, Age: 50
```

4. Getters and Setters with Exceptions:
```php
class Chef {
    protected $name;
    protected $age;

    // Constructor with optional parameters
    public function __construct($name = "Unknown Chef", $age = 30) {
        $this->name = $name;
        $this->setAge($age); // Use the setter to validate age
    }

    // Getter for name
    public function getName() {
        return $this->name;
    }

    // Setter for name
    public function setName($name) {
        $this->name = $name;
    }

    // Getter for age
    public function getAge() {
        return $this->age;
    }

    // Setter for age
    public function setAge($age) {
        if ($age > 0) { // Simple validation to ensure age is positive
            $this->age = $age;
        } else {
            throw new InvalidArgumentException("Age must be positive.");
        }
    }

    public function getInfo() {
        return "Chef: {$this->name}, Age: {$this->age}";
    }
}
```

5. Inheritance:
```php
// Inheritance
	class Chef {
			protected $name;
			protected $age;
			
			//note: php does not allow overloaded constructors, you're limited to just 1 constructor
			function __construct($name,$age){
					$this->name = $name;
					$this->age  = $age;
			}
			function makeChicken() {
				echo "$this->name makes chicken<br>";
			}
			function makeSalad(){
				echo "$this->name  makes salad<br>";
			}
			function makeSpecialDish(){
				echo "$this->name makes bbq ribs<br>";
			}
			function getAge(){
				return $this->age;
			}
	};
	
	
	class ItalianChef extends Chef {
			public $countryOfOrigin;
			
			function __construct($name,$age,$countryOfOrigin){
				$this->countryOfOrigin = $countryOfOrigin;
				parent::__construct($name,$age);
			}
			function makePasta(){
				echo "{$this->name} makes pasta<br>";
			}
			function makeSpecialDish(){
				echo "{$this->name} makes chicken parm<br>";
			}
	};
```