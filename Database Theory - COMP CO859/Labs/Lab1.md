
1. Find person closest to your date of birth:
```sql
SELECT * 
FROM patients
ORDER BY birth_date ASC;
```

2. Count number of rows in something
```sql
SELECT *
FROM nursing_units;
```

3. Find strawberry allergies
```sql
SELECT * 
FROM patients
WHERE allergies='Strawberries';
```

4. Location of patient
```sql
SELECT *
FROM patients
WHERE SUBSTRING(postal_code,1,5)='L8M 3';
```

