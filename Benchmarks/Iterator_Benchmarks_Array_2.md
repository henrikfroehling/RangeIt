### Iterator Benchmarks - Array `KeyValuePair<T, U>[]`

``` ini
BenchmarkDotNet=v0.10.1, OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i5-2500K CPU 3.30GHz, ProcessorCount=4
Frequency=3233206 Hz, Resolution=309.2905 ns, Timer=TSC
  [Host]     : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.6.1586.0 [AttachedDebugger]
  DefaultJob : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.6.1586.0

Allocated=0 B  
```

---

**`KeyValuePair<T, U>[]` Array - 500 iterations - `ConstIterator<T, U>`**

|                                         Method |        Mean |    StdDev |         Min |         Max |
|----------------------------------------------- |------------: |----------: |------------: |------------: |
|                  Array_2_Integer_ConstIterator |   2.3923 ns | 0.0201 ns |   2.3596 ns |   2.4338 ns |
| Array_2_Integer_ConstIterator_OperatorOverload |   7.0312 ns | 0.0283 ns |   6.9814 ns |   7.0699 ns |
|                     Array_2_Integer_Enumerator | 169.2653 ns | 0.2434 ns | 168.9660 ns | 169.7549 ns |
|                   Array_2_String_ConstIterator |   2.3830 ns | 0.0123 ns |   2.3649 ns |   2.4051 ns |
|  Array_2_String_ConstIterator_OperatorOverload |   7.3313 ns | 0.0419 ns |   7.2860 ns |   7.4217 ns |
|                      Array_2_String_Enumerator | 169.5619 ns | 0.6643 ns | 168.7920 ns | 170.6945 ns |

---

**`KeyValuePair<T, U>[]` Array - 500 iterations - `Iterator<T, U>`**

|                                    Method |        Mean |    StdDev |         Min |         Max |
|------------------------------------------ |------------: |----------: |------------: |------------: |
|                  Array_2_Integer_Iterator |   2.9622 ns | 0.1014 ns |   2.8723 ns |   3.1367 ns |
| Array_2_Integer_Iterator_OperatorOverload |   7.4899 ns | 0.1490 ns |   7.2519 ns |   7.8217 ns |
|                Array_2_Integer_Enumerator | 164.7350 ns | 1.0140 ns | 162.8931 ns | 166.9250 ns |
|                   Array_2_String_Iterator |   2.9547 ns | 0.0534 ns |   2.8648 ns |   3.0745 ns |
|  Array_2_String_Iterator_OperatorOverload |   6.9626 ns | 0.0217 ns |   6.9212 ns |   6.9955 ns |
|                 Array_2_String_Enumerator | 161.7866 ns | 2.0642 ns | 158.7053 ns | 166.0296 ns |
