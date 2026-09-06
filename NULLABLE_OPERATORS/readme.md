### ?? — Null-Coalescing Operator

> **"If the value on the left is null, use the value on the right."**

```
value ?? defaultValue
```
```
string name = null;

string result = name ?? "Guest";

Console.WriteLine(result);
```

---
### ??= — Null-Coalescing Assignment Operator

> **"Assign a value only if the variable is currently null."**

```
variable ??= value;
```
```
string name = null;

name ??= "Guest";

Console.WriteLine(name);
```

---
### ?. — Null-Conditional Operator

> **"Access this member only if the object is not null."**

```
object?.Property, object?.Method()
```
```
string name = null;

int? length = name?.Length;

Console.WriteLine(length);
```

---
### ?[] — Null-Conditional Element Access Operator

> **"Access the element only if the object is not null."**

```
string[] names =
{
    "Satya",
    "Ravi",
    "John"
};
string firstName = names?[0];
Console.WriteLine(firstName);
```