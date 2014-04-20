# RuleSet

Simplify hideous conditional blocks with declarative logic

## Why?

There are few things more rage-inducing than encountering huge chunks of
conditional logic, which are often responsible for hugely important components
of a given piece of software.

Rather than tightly coupling the given piece of logic with an explicit
conditional flow, we can instead define the logic independently of any specific
code, allowing for a much more flexible approach.

## Install

You can install `RuleSet` using NuGet:

```powershell
PM> Install-Package RuleSet
```

`RuleSet` is a PCL and supports the following platforms:
- .NET 4.0 or later (incl. Mono)
- Xamarin.iOS
- Xamarin.Android
- Windows Store 8
- Windows Phone 8
- Silverlight 5

## Example

### Wrong

Writing a simple calculator using only nested conditionals can get very ugly,
very quickly.

```csharp
if (operation != null) {
  if (operation == Operation.Add) {
    return x + y;
  } else if (operation == Operation.Subtract) {
    return x - y;
  } else if (operation == Operation.Multiply) {
    return x * y;
  } else if (operation == Operation.Divide) {
    return x / y;
  } else {
    return null;
  }
} else {
  return null;
}
```

### Right

Fortunately, `RuleSet` lets us refactor this giant blob of code using a much
more manageable approach.

```csharp
var calculator = new RuleSet<Operation,Func<int,int,int>>(defaultResult: null);

calculator.When(Operation.Add).Then((x,y) => x + y);
calculator.When(Operation.Subtract).Then((x,y) => x - y);
calculator.When(Operation.Multiply).Then((x,y) => x * y);
calculator.When(Operation.Divide).Then((x,y) => x / y);

return calculator.First(Operation.Add)(1,2);   // returns 3
```

This is but a simple, highly contrived example, yet it has massive implications
to avoid writing terrible blocks of imperative, nested conditional logic.

## Usage

### RuleSet

The first step of using `RuleSet` is to instantiate a
`RuleSet<T1,T2,…,TN,TResult>` object with the desired generic types.

```csharp
var ruleSet = new RuleSet<Operation,Func<int,int,int>>();
```

The `RuleSet` constructor takes one optional argument, which is the default
object of type `TResult` to be returned when no `Rule`s are matched.

The first few generic types define the inputs required to identify a matching
`Rule`. In this case, we've defined that an `Operation` object will be
used to try matching each `Condition`. As you can see, many generic input types
can be specified.

After all the generic input types comes the `TResult` type, which is returned
from the `Rule` whose `Condition` is matched. In this case, a `Func` is
returned, which takes two `int`s and returns another `int`.

This `RuleSet` allows us to define `Condition`s which match against different
`Operation` enum values and return the respective `Func` to perform the given
mathematical operation.

### When

The `When` method is called on a `RuleSet` to define the `Condition` for a given
`Rule`. `When` method returns a builder object which lets us finish building
a `Rule` by calling the `Then` method.

If a simple equality check against each generic input type is all that is
required, `When` accepts an instance of each generic input type `T1`, `T2` up to
`TN`, and generates the required `Func<T1,T2,…,TN,bool>` method for you, using
an equality comparison on each object.

In the case of more advanced logic being required to evaluate the `Condition`
being defined, your own `Func<T1,T2,…,TN,bool>` can be supplied, which allows
you to implement the logic required to match the `Condition`.

### Then

Passing an object of type `TResult` to the `Then` method will complete the
process of defining a `Rule` within our `RuleSet`.

The type you define `TResult` to be is only limited by your imagination. It
could be a simple primitive type, or it could be an `Action` or `Func` of your
own making, allowing you to invoke complex logic after matching against a
collection of `Condition`s.

### First

Now that we've defined one or more rules, we can find the first matching `Rule`.
This takes arguments of types `T1`, `T2` and so on, up to `TN`.

The given arguments are used to invoke each `Condition` to find the first one
which evaluates to `true`. The `Result` property of the matching `Rule` is returned.

### All

If we instead want all `Result` objects to be returned from all matching
`Rule`s, we can call `All` instead of `First`. This instead evaluates all `Rule`
objects within the `RuleSet` and returns the `Result` properties for each `Rule`
whose `Condition` evaluates to `true`.

## Development

A copy of .NET or Mono is required to build the solution. You can install Mono
on OS X by running `brew bundle`, assuming you have Homebrew installed.

The supplied `Makefile` defines the following targets:
- `make clean`
- `make build`
- `make test`

## Links

- [RuleSet on NuGet](https://www.nuget.org/packages/RuleSet)
