RangeIt
===
### [Ranges](https://github.com/henrikfroehling/RangeIt#ranges) and [Iterators](https://github.com/henrikfroehling/RangeIt#iterators)
##### Contains a collection of helper methods (`Range.Ints()` and `Range.Iota()`) for generating ranges of arbitrary type. Adds also [iterators for common collections](https://github.com/henrikfroehling/RangeIt#iterators).

[![License](https://img.shields.io/badge/License-MIT-blue.svg?style=flat)](https://opensource.org/licenses/MIT)
[![Build status branch master](https://ci.appveyor.com/api/projects/status/rntqj6d2o7t8uo0s/branch/master?svg=true&passingText=master%20-%20passing&pendingText=master%20-%20pending&failingText=master%20-%20failing)](https://ci.appveyor.com/project/henrikfroehling/rangeit/branch/master)
[![Build status branch dev](https://ci.appveyor.com/api/projects/status/rntqj6d2o7t8uo0s/branch/dev?svg=true&passingText=dev%20-%20passing&pendingText=dev%20-%20pending&failingText=dev%20-%20failing)](https://ci.appveyor.com/project/henrikfroehling/rangeit/branch/dev)
[![Zenhub Support](https://raw.githubusercontent.com/ZenHubIO/support/master/zenhub-badge.png)](https://www.zenhub.com/)

![Platforms](https://img.shields.io/badge/Platforms-.Net%20%3E%3D%204.5%20%7C%20.Net%20Core%20%3E%3D%201.0%20%7C%20ASP%20.Net%20Core%20%3E%3D%201.0%20%7C%20Win%208%20%7C%20Win%208.1%20%7C%20Win%2010%20%7C%20Win%2010%20UWP%20%7C%20Win%20Phone%208.1%20%7C%20Mono%20%3E%3D%204.6%20%7C%20Xamarin%20Android%20%7C%20Xamarin%20iOS-orange.svg)

### Ranges

#### Ranges Usage Examples
```csharp
using RangeIt.Ranges;

var intRange = Range.Ints(10);
// intRange == { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }

// with start value
var intRange = Range.Ints(5, 10);
// intRange == { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }

// with step value
var intRange = Range.IntsWithStep(10, 2);
// intRange == { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 }

// with start value / with step value
var intRange = Range.IntsWithStep(5, 10, 2);
// intRange == { 5, 7, 9, 11, 13, 15, 17, 19, 21, 23 }

// ----------------------------

// from - to
var intRange = Range.Iota(5, 20);
// intRange == { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }

// from - to / with step value
var intRange = Range.Iota(5, 20, 2);
// intRange == { 5, 7, 9, 11, 13, 15, 17, 19 }

// ----------------------------

var strRange = Range.Iota("hello", (s) => s + "a", (s) => s?.Length == 10);
// strRange = { "hello", "helloa", "helloaa", "helloaaa", "helloaaaa", "helloaaaaa" }
```

**There are many more overloads, especially for `Range.Iota()`.**

### Iterators

**Supported Collections - [Benchmarks](https://github.com/henrikfroehling/RangeIt/tree/dev/Benchmarks)**

| Collection                   | Iterator         | ConstIterator         |
|------------------------------|------------------|-----------------------|
| `T[]`                        | `Iterator<T>`    | `ConstIterator<T>`    |
| `KeyValuePair<T, U>[]`       | `Iterator<T, U>` | `ConstIterator<T, U>` |
| `List<T>`                    | `Iterator<T>`    | `ConstIterator<T>`    |
| `Collection<T>`              | `Iterator<T>`    | `ConstIterator<T>`    |
| `Dictionary<T, U>`           | `Iterator<T, U>` | `ConstIterator<T, U>` |
| `ConcurrentDictionary<T, U>` | `Iterator<T, U>` | `ConstIterator<T, U>` |
| `ReadOnlyCollection<T>`      | xxx              | `ConstIterator<T>`    |
| `ReadOnlyDictionary<T, U>`   | xxx              | `ConstIterator<T, U>` |

#### Iterators Usage Examples
```csharp
using RangeIt.Iterators;

var list = new List<int> { 1, 2, 3, 4, 5 };
var it = list.Begin();

// Looping forward
while (it++)
    Console.WriteLine(it.Current);

// not necessary after looping completely forward
it = list.End();

// Looping backward
while (--it)
    Console.WriteLine(it.Current);

// change second element
// list = { 1, 2, 3, 4, 5 }
it = list.Begin();

it = it + 2;
it.Current = 7;
// list = { 1, 7, 3, 4, 5 }

it = list.Begin();

// Using iterator like an enumerator
foreach (var val in it)
    Console.WriteLine(val);

// ---------------------------
// ---------------------------
// const iterator
var it = list.ConstBegin();

// Looping forward
while (it++)
    Console.WriteLine(it.Current);

// Looping backward
while (it--)
    Console.WriteLine(it.Current);

it = list.ConstBegin() + 2;

// changing second element not possible,
// since it is a const iterator,
// this won't compile
// it.Current = 7;

it = list.ConstBegin();

// Using iterator like an enumerator
foreach (var val in it)
    Console.WriteLine(val);
```

### License
```
The MIT License (MIT)

Copyright (c) 2016 - 2017 Henrik Fröhling

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```
