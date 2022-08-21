# Ladon.Net

## What is Ladon.Net ?
A lightweight, low overhead, low ceremony, cross platform library for guarding against bad method inputs.

*[Ladon protects your golden apples](https://en.wikipedia.org/wiki/Ladon_(mythology))*

[![GitHub license](https://img.shields.io/github/license/mashape/apistatus.svg)](https://github.com/Yortw/Ladon.Net/blob/master/LICENSE) [![Build status](https://ci.appveyor.com/api/projects/status/waxmch4c6sm96vaa?svg=true)](https://ci.appveyor.com/project/Yortw/ladon-net) [![NuGet Badge](https://buildstats.info/nuget/Ladon.Net)](https://www.nuget.org/packages/Ladon.Net/)

## Philosophy

* Light weight - the library should be small and cover all of the most common guard cases, without trying to cover every conceivable case. Common cases include null, 'empty', min/max/ranged restrictions, zero/negative values and explicitly forbidden values. The library binary should be small and free of other dependencies outside the core runtimes.

* Low overhead - Guard clauses will be executed often but should **not** "activate" often so Ladon should be optimized for the 'happy path'. This means in the case where no exception is thrown, Ladon should have a minimum impact on *both* execution time and allocations/memory usage. Where it is not possible to optimise for both time/memory, a sensible trade off between the two should be made for the most common scenario.

* Low ceremony - We all want readable code, and we do have intellsense/auto-complete, but no one wants 40 character methods names and 100 method arguments if they can be avoided. Ladon should require zero (or at least very little) config and have short, meaningful names with the minimum number of parameters. The parameter types should be simple and we should avoid 'magic' - no passing lambda expressions and trying to parse out argument names. Dumb, but simple & as short as possible for the calls is the goal.

* Cross platform - We'd love to say, "Ladon goes where .Net does", but at the moment due to some technical issues we're not supporting a number of older platforms (i.e Silverlight, WPSL, .Net prior to 4). However we do support .Net 4 as well as any platform supported Net Standard 1.0. Other platforms may be available in the future. Feel free to embed the source or fork the project if you want support for platforms not supported by the official package.

## Other Features

* Ladon contains a ValidatedNotNullAttribute attribute which is used to decorate guard clauses that check for null, integrating nicely with code analysis. This attribute is scoped as public, so you can apply it to your own custom guard clauses in your application code without redefining your own version.

* Ladon guard clauses are marked and designed to *encourage* in-lining by the compiler where possible, for optimum performance. This only applies in optimised (release) builds.

## Supported Platforms
Currently;

* .Net Standard 2.0
* .Net Standard 2.1
* .Net 4.5
* .Net 4.6
* .Net 5.0
* .Net 6.0

## How do I use it?

Ladon supports three styles of usage. The recommended way is to use extension methods, for example;

```c#
    using Ladon;

    public string GetGreeting(string name)
    {
        name.GuardNullOrWhiteSpace(nameof(name));
        name.GuardLength(nameof(name), 100);

        return "Hello " + name;
    }
```

If you prefer or need to go old school, you can call the guard methods directly;

```c#
    using Ladon;
    
    public string GetGreeting(string name)
    {
        Guard.GuardNullOrWhiteSpace(name, nameof(name));
        Guard.GuardLength(name, nameof(name), 100);

        return "Hello " + name;
    }
```

It is possible to chain guard clauses together if you want in a semi-fluent style. Ladon guard clauses return the value that was validated, so this does not create any kind of fluent builder/wrapper object and keeps the code allocation free/low. Because the value is returned as it's native type (as opposed to boxing) where possible, other extension methods can be called on the result of a prior guard call, though the name must still be passed for every call, e.g.

```c#
    using Ladon;

    public string GetGreeting(string name)
    {
        name.GuardNullOrWhiteSpace(nameof(name)).GuardLength(nameof(name), 100);

        return "Hello " + name;
    }
```

Finally it is also possible to guard and assign as a single line/statement;

```c#
    using Ladon;

    public class MyType
    {
        private string _Name;

        public  MyType(string name)
        {
            _Name = name.GuardNullOrWhiteSpace(nameof(name)).GuardLength(nameof(name), 100);
        }
    }
```

The Ladon.Guard class contains all the available guard clauses, so use intellisense to check out what's available.

### Method Naming
Because the recommended usage pattern is via extension methods, all methods start with the word *Guard* so they make sense when viewed via intellisense as an extension method call. To keep the method names short, the pattern is Guard&lt;*FailureCondition*&gt;, so method names should be read as, 'GuardAgainst*Condition*', i.e *GuardNull* should be read as *GuardAgainstNull*.

