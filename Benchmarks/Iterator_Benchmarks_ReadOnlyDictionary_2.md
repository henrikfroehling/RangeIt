### Iterator Benchmarks - `ReadOnlyDictionary<T, U>`

``` ini
BenchmarkDotNet=v0.10.1, OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i5-2500K CPU 3.30GHz, ProcessorCount=4
Frequency=3233206 Hz, Resolution=309.2905 ns, Timer=TSC
  [Host]     : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.6.1586.0 [AttachedDebugger]
  DefaultJob : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.6.1586.0

Allocated=0 B  
```

---

**`ReadOnlyDictionary<T, U>` - 500 iterations - `ConstIterator<T, U>`**

|                                                      Method |          Mean |      StdDev |           Min |           Max | Allocated |
|------------------------------------------------------------ |--------------: |------------: |--------------: |--------------: |----------: |
|                  ReadOnlyDictionary_2_Integer_ConstIterator |     2.9875 ns |   0.0350 ns |     2.9459 ns |     3.0502 ns |       0 B |
| ReadOnlyDictionary_2_Integer_ConstIterator_OperatorOverload |     7.2283 ns |   0.1387 ns |     7.0841 ns |     7.5545 ns |       0 B |
|                     ReadOnlyDictionary_2_Integer_Enumerator | 5,492.2198 ns |  94.5977 ns | 5,400.4932 ns | 5,694.9648 ns |      32 B |
|                   ReadOnlyDictionary_2_String_ConstIterator |     2.9508 ns |   0.0232 ns |     2.9209 ns |     2.9846 ns |       0 B |
|  ReadOnlyDictionary_2_String_ConstIterator_OperatorOverload |     7.7029 ns |   0.0729 ns |     7.6294 ns |     7.8841 ns |       0 B |
|                      ReadOnlyDictionary_2_String_Enumerator | 9,338.8285 ns | 114.4880 ns | 9,209.3647 ns | 9,582.6408 ns |      32 B |
