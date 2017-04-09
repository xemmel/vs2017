# Morten la Cour
## My First Visual Studio (C# 7) stuff


## Table of content
1. [Tuples](#tuples)
1. [Out Variables](#out-variables)
1. [Pattern matching](#pattern-matching)
1. [Tuples](#tuples)





# Tuples

```csharp

		//Anonymous (o.Item1, o.Item2)
        public (string,string) GetFullName()
        {
            return (_firstName, _lastName);
        }

		//Declared (o.firstName, o.lastName)
        public (string firstName, string lastName) GetStrongFullName()
        {
            return (_firstName, _lastName);
        }

```

[Back to top](#table-of-content)


# Out Variables

```csharp
           // string fName, lName;
            p.GetOutVarName(out string fName, out string lName);
            Console.WriteLine($"Hello {fName} {lName}");
```

[Back to top](#table-of-content)

# Pattern matching

Bla. bla. bla.

[Back to top](#table-of-content)




