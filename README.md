AP.ResharperAnnotationsDemo
===========================

This is a demo project for Albumprinter BV .Net team.


What does R# offers us in ```JetBrains.Annotations``` library?
--------------------------------------------------------


Type system limitations
--------------------

C# typesystem is limited in some cases, so we might need a tool to express some extra ideas in code.

* Null-NotNull attribute

Demo:

```csharp
[CanBeNull]
public static string CanReturnNull(string parameter)
{
	var rand = new Random();
    return (rand.Next()%2) == 0 ? "string" : null;
}
```


* Pure attribute

In computer programming, a function may be described as a pure function if both these statements about the function hold:
> 1. The function always evaluates the same result value given the same argument value(s). The function result value cannot depend on any hidden information or state that may change as program execution proceeds or between different executions of the program, nor can it depend on any external input from I/O devices.
> 2. Evaluation of the result does not cause any semantically observable side effect or output, such as mutation of mutable objects or output to I/O devices.
> 
>(c) Wikipedia

Demo

```csharp
public class MyInt
{
	private readonly int value;
	public MyInt(int value)
    {
    	this.value = value;
    }

    public int Value
    {
        get { return value; }
    }
        
    [Pure]
    public MyInt Add(int add)
    {
        return new MyInt(Value + add);
    }
}
```

* Contracts

```[CanBeNull]``` and ```[NotNull]``` does not allow us to express any conditions. So the Method can be either NotNull either CanBeNull. Not both of them.


Demo

```csharp
public static class ContractTest
{
    [ContractAnnotation("str:null => null;str:notnull=>notnull")]
    public static string Reverse(string str)
    {
        if (str == null) return null;
   		return new string(str.Reverse().ToArray());
    }
}
```





Usage
-----

* ```[PublicApi]```, ```[UsedImplisitly]``` attributes
 
Demo


Code helpers
------------

* Resource navigation

Demo 

* Custom string formatting

Demo

What to read
------------

* How to add Jetbrains.Annotations to you solution.
http://www.jetbrains.com/resharper/webhelp/Code_Analysis__Annotations_in_Source_Code.html
* List of attributes 
http://www.jetbrains.com/resharper/webhelp/Reference__Code_Annotation_Attributes.html

* Contracts http://blog.jetbrains.com/dotnet/2012/08/15/contract-annotations-in-resharper-7
* http://stackoverflow.com/questions/24805040/how-to-ignore-reference-to-jetbrains-annotations-dll-in-nodatime-nuget-package-x




