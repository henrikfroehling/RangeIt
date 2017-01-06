### Iterator Benchmarks - `ArrayList`

``` ini
BenchmarkDotNet=v0.10.1, OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i5-2500K CPU 3.30GHz, ProcessorCount=4
Frequency=3233206 Hz, Resolution=309.2905 ns, Timer=TSC
  [Host]     : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.6.1586.0 [AttachedDebugger]
  DefaultJob : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.6.1586.0

Allocated=0 B  
```

---

**`ArrayList` - 500 iterations - `ConstIterator`**

|                                           Method |          Mean |     StdDev |           Min |           Max | Allocated |
|------------------------------------------------- |--------------: |-----------: |--------------: |--------------: |----------: |
|                  ArrayList_Integer_ConstIterator |     2.8915 ns |  0.0553 ns |     2.8061 ns |     3.0095 ns |       0 B |
| ArrayList_Integer_ConstIterator_OperatorOverload |     7.5040 ns |  0.0299 ns |     7.4582 ns |     7.5737 ns |       0 B |
|                     ArrayList_Integer_Enumerator | 4,819.1605 ns | 27.7743 ns | 4,782.8585 ns | 4,868.2419 ns |      28 B |
|                   ArrayList_String_ConstIterator |     2.8493 ns |  0.0153 ns |     2.8241 ns |     2.8749 ns |       0 B |
|  ArrayList_String_ConstIterator_OperatorOverload |     7.4989 ns |  0.0226 ns |     7.4617 ns |     7.5339 ns |       0 B |
|                      ArrayList_String_Enumerator | 4,816.1369 ns | 14.5381 ns | 4,795.5889 ns | 4,852.7597 ns |      28 B |

---

**`ArrayList` - 500 iterations - `Iterator`**

|                                      Method |          Mean |     StdDev |           Min |           Max | Allocated |
|-------------------------------------------- |--------------: |-----------: |--------------: |--------------: |----------: |
|                  ArrayList_Integer_Iterator |     2.8595 ns |  0.0109 ns |     2.8392 ns |     2.8808 ns |       0 B |
| ArrayList_Integer_Iterator_OperatorOverload |     7.5290 ns |  0.0507 ns |     7.4571 ns |     7.6054 ns |       0 B |
|                ArrayList_Integer_Enumerator | 4,842.6074 ns | 36.6801 ns | 4,774.7858 ns | 4,930.5874 ns |      28 B |
|                   ArrayList_String_Iterator |     2.8513 ns |  0.0303 ns |     2.8075 ns |     2.9101 ns |       0 B |
|  ArrayList_String_Iterator_OperatorOverload |     7.5049 ns |  0.0529 ns |     7.4038 ns |     7.5780 ns |       0 B |
|                 ArrayList_String_Enumerator | 4,839.6647 ns | 47.6417 ns | 4,773.9036 ns | 4,921.7624 ns |      28 B |
