###### [Sam Scott Video Lecture 2](https://www.youtube.com/watch?v=S6itfPa9lA0)

- ###### Things you should know:
	- PHP is an interpreted language. Source code is run and interpreted into machine language. Ran top to bottom 
	- PHP is imperative programming (Lines of code wherever, no need for mains or classes)
	- PHP is dynamically typed. 
	- PHP is a fully functional language
	- PHP is weakly typed.  No type errors. PHP will try and convert types on the fly.

- ###### Variables:
	- Declare variables:  `$a = 10;`
	- PHP reads from top down. 
	  Example of global scoped variable below:
	- ![[Pasted image 20240922141432.png]]
	- **==PHP constants do not require dollar sign.==** 
###### Outputting to Browser in Different Ways:
```php
echo "A is: $a"
<p>A is <?= $a ?></p>
<p>Hello <?=$name?></p>
```

###### Vardump:
- A way to view data type of variable 
```php
    <pre>
        <?php
            var_dump($a);

            var_dump($name);
        ?>
    </pre>
```

###### Gotchas:
![[Pasted image 20240922143719.png]]

The code below assigns "6" to $guess and evaluates to true. Any string that isn't empty evaluates to True. Empty strings evaluate to False.
![[Pasted image 20240922143827.png]]

###### Random Dice Example:
```php
	for ($i=0; $i < 5; $i++) {

		echo  "<div><p>". rand(1, 6) . "</p></div>";

	}
```

