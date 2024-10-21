**Assignment 2 Review**
![[Pasted image 20241010143036.png]]
```php
  
<?php
header("Content-type: application/json");




$filename = "store.json";
$jsonStr = file_get_contents($filename);    //to string
echo $jsonStr;
echo "\n\n\n";





$arr = json_decode($jsonStr, true);   //to associative array
print_r($arr);
echo "\n\n\n";




echo json_encode($arr, JSON_PRETTY_PRINT);
?>
```

