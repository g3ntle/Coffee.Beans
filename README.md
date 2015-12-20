# Coffee.Beans

**Object population simplified**

![Logo][logo]

## Overview

* [Installation](#installation)
* [Example](#example)

## Installation

```
nuget install Coffee.Beans -Source http://robhendriks.azurewebsites.net/nuget
```

## Example

```cs
class Person
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
}
```

```cs
var person = new Person();

var values = new Dictionary<string, object>()
{
	{ "FirstName", "John" },
	{ "LastName", "Doe" }
};

person.Fill(values);
```

```cs
Console.WriteLine($"{person.FirstName} {person.LastName}");
```

```
> John Doe
```

[logo]: /docs/logo-64x64.png