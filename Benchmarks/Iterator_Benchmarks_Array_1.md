### Iterator Benchmarks - Array `T[]`

``` ini
BenchmarkDotNet=v0.10.1, OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i5-2500K CPU 3.30GHz, ProcessorCount=4
Frequency=3233206 Hz, Resolution=309.2905 ns, Timer=TSC
  [Host]     : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.6.1586.0 [AttachedDebugger]
  DefaultJob : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.6.1586.0

Allocated=0 B  
```

---

**`T[]` Array - 500 iterations - `ConstIterator<T>`**

|                                         Method |        Mean |    StdDev |         Min |         Max |
|----------------------------------------------- |------------: |----------: |------------: |------------: |
|                  Array_1_Integer_ConstIterator |   2.8967 ns | 0.0285 ns |   2.8489 ns |   2.9564 ns |
| Array_1_Integer_ConstIterator_OperatorOverload |   7.3458 ns | 0.1203 ns |   7.1560 ns |   7.5107 ns |
|                     Array_1_Integer_Enumerator | 236.9971 ns | 0.6667 ns | 235.9646 ns | 238.0152 ns |
|                   Array_1_String_ConstIterator |   2.9743 ns | 0.0693 ns |   2.8927 ns |   3.0810 ns |
|  Array_1_String_ConstIterator_OperatorOverload |   7.0390 ns | 0.0834 ns |   6.9538 ns |   7.2065 ns |
|                      Array_1_String_Enumerator | 240.6515 ns | 2.3199 ns | 238.3766 ns | 247.0022 ns |

---

**`T[]` Array - 500 iterations - `Iterator<T>`**

|                                    Method |        Mean |    StdDev |         Min |         Max |
|------------------------------------------ |------------: |----------: |------------: |------------: |
|                  Array_1_Integer_Iterator |   2.8627 ns | 0.0209 ns |   2.8267 ns |   2.8989 ns |
| Array_1_Integer_Iterator_OperatorOverload |   7.3239 ns | 0.0884 ns |   7.2166 ns |   7.5228 ns |
|                Array_1_Integer_Enumerator | 238.3563 ns | 2.0965 ns | 236.1027 ns | 243.6517 ns |
|                   Array_1_String_Iterator |   2.9602 ns | 0.0421 ns |   2.8956 ns |   3.0257 ns |
|  Array_1_String_Iterator_OperatorOverload |   7.0660 ns | 0.0856 ns |   6.9327 ns |   7.2515 ns |
|                 Array_1_String_Enumerator | 238.2689 ns | 0.7143 ns | 237.2014 ns | 239.5407 ns |
