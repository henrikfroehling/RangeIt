### Iterator Benchmarks - `ReadOnlyCollection<T>`

``` ini
BenchmarkDotNet=v0.10.1, OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i5-2500K CPU 3.30GHz, ProcessorCount=4
Frequency=3233206 Hz, Resolution=309.2905 ns, Timer=TSC
  [Host]     : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.6.1586.0 [AttachedDebugger]
  DefaultJob : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.6.1586.0

Allocated=0 B  
```

---

**`ReadOnlyCollection<T>` - 500 iterations - `ConstIterator<T>`**

|                                                      Method |          Mean |     StdDev |           Min |           Max | Allocated |
|------------------------------------------------------------ |--------------: |-----------: |--------------: |--------------: |----------: |
|                  ReadOnlyCollection_1_Integer_ConstIterator |     2.7505 ns |  0.0329 ns |     2.6896 ns |     2.8225 ns |       0 B |
| ReadOnlyCollection_1_Integer_ConstIterator_OperatorOverload |     7.4884 ns |  0.0511 ns |     7.4015 ns |     7.5649 ns |       0 B |
|                     ReadOnlyCollection_1_Integer_Enumerator | 3,720.3189 ns | 19.9960 ns | 3,687.5178 ns | 3,754.9155 ns |      24 B |
|                   ReadOnlyCollection_1_String_ConstIterator |     2.7416 ns |  0.0371 ns |     2.7008 ns |     2.8208 ns |       0 B |
|  ReadOnlyCollection_1_String_ConstIterator_OperatorOverload |     6.9987 ns |  0.1095 ns |     6.8868 ns |     7.2392 ns |       0 B |
|                      ReadOnlyCollection_1_String_Enumerator | 5,143.9070 ns | 65.8162 ns | 5,072.0240 ns | 5,286.4876 ns |      24 B |
