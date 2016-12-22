Ranges
===

---
### Status
**Currently just a collection of helper methods (`Range.Ints()` and `Range.Iota()`) for generating ranges of arbitrary type.**

### ToDo

- [ ] Setup Contiguous Integration (AppVeyor)
- [ ] Create NuGet package
- [ ] Add extension methods for class `Range<T>` and `Range<T, U>` to support LINQ properly

### Usage Examples
```
var intRange = Range.Ints(1, 11);
// intRange == { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }

var strRange = Range.Iota("hello", (s) => s + "a", (s) => s?.Length == 10);
// strRange = { "hello", "helloa", "helloaa", "helloaaa", "helloaaaa", "helloaaaaa" }
```

**This are just two usage examples. There are many more overloads, especially for `Range.Iota()`.**

### License
```
The MIT License (MIT)

Copyright (c) 2016 Henrik Fr�hling

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
