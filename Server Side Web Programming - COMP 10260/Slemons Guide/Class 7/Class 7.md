###### **Regex**
```php
    $str = "My name is Thomas Coons, Thomas is my first name.";

    //Return true or false. preg_match searches for something in a string  to match. ONLY returns first occurence.
    if (preg_match("/Thomas/", $str)) {
        echo "yes";
    }

    //pre_match_all returns ALL occurences. This creates a two-d array...
    if (preg_match_all("/Thomas/", $str, $arr)) {
        echo print_r($arr);
    }

    //We can also put the result into an array
    if (preg_match("/Thomas/", $str, $arr)) {
        echo print_r($arr);
    }

    //Searching multiple things at once.
    if (preg_match_all("/Th(o)mas/", $str, $arr)) {
        echo print_r($arr);
    }

    //Searching and replacing.
    $str2 = preg_replace("/Thomas/", "Joe", $str);
    echo $str2;
```

- More on regex [here](https://youtu.be/DTQDMKx4Rks?feature=shared)
- -- 
Matching a Mohawk College Student Number (9-digit format)  
_000760123_

`/^\d{9}$/`
- -- 
Matching an Ant String (only < and > allowed, any length)  
_<..>_

`/^[<->]*$/`
- -- 
Matching an Integer of Any Length  
_-123456_

`/^-?\d+$/`
- -- 
Matching a Single Dictionary Word  
_dictionary_

`/^[A-Za-z]+$/`
- -- 
Matching a First and Last Name  
_John O'Connor_

`/^[A-Za-z]+([\'-]?[A-Za-z]+)?\s[A-Za-z]+([\'-]?[A-Za-z]+)?$/`
- -- 
Matching an Email Address  
_dave@mohawk.ca_

`/^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/`
- -- 
Matching a URL  
_https://www.example.com_

`/\b((http(s)?:\/\/)?(www\.)?[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}(\/\S*)?)\b/`
- -- 
Matching a Phone Number  
_(555) 555-1212_

`/^\(?\d{3}\)?[-.\s]?\d{3}[-.\s]?\d{4}$/`
- -- 
Matching a Date  
_YYYY-MM-DD_

`/^\d{4}-\d{2}-\d{2}$/`
- -- 
Matching a Canadian Postal Code  
_L5M 5E6_

`/^[A-Za-z]\d[A-Za-z] ?\d[A-Za-z]\d$/`
- -- 
Matching a 5-Digit US ZIP Code  
_12345_

`/^\d{5}$/`
- -- 
Matching Alphanumeric Strings (Letters and Numbers)  
_Test123_

`/^[a-zA-Z0-9]+$/`
- -- 
Matching a Password  
_(At least 8 characters, with one uppercase, one lowercase, one number, e.g. Password1)_

`/^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)[A-Za-z\d]{8,}$/`
- -- 
Matching Alphanumeric Strings (Letters and Numbers)  
_Test123_

`/^[a-zA-Z0-9]+$/`