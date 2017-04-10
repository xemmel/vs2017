# Morten la Cour
## My First Visual Studio (C# 7) stuff


## Table of content
1. [Tuples](#tuples)
1. [Out Variables](#out-variables)
1. [Pattern matching](#pattern-matching)
1. [Tuples](#tuples)





# Tuples

## install nuget-package

```
install-package System.ValueTuple
```


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


```csharp 

 public static void YellIfPossible(Person p)
        {
            if (!(p is Boss b))
            {
                Console.WriteLine($"{p.GetStrongFullName().firstName} can't yell");
                return;
            }
            b.Yell();
        }

```

[Back to top](#table-of-content)




