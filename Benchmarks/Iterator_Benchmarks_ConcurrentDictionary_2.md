### Iterator Benchmarks - `ConcurrentDictionary<T, U>`

``` ini
BenchmarkDotNet=v0.10.1, OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i5-2500K CPU 3.30GHz, ProcessorCount=4
Frequency=3233206 Hz, Resolution=309.2905 ns, Timer=TSC
  [Host]     : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.6.1586.0 [AttachedDebugger]
  DefaultJob : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.6.1586.0

Allocated=0 B  
```

---

**`ConcurrentDictionary<T, U>` - 500 iterations - `ConstIterator<T, U>`**

|                                                        Method |           Mean |      StdDev |            Min |            Max | Allocated |
|-------------------------------------------------------------- |---------------: |------------: |---------------: |---------------: |----------: |
|                  ConcurrentDictionary_2_Integer_ConstIterator |      3.2304 ns |   0.0147 ns |      3.2032 ns |      3.2529 ns |       0 B |
| ConcurrentDictionary_2_Integer_ConstIterator_OperatorOverload |      7.3690 ns |   0.0853 ns |      7.2830 ns |      7.5862 ns |       0 B |
|                     ConcurrentDictionary_2_Integer_Enumerator |  6,686.7446 ns |  31.8274 ns |  6,638.8169 ns |  6,738.7360 ns |      36 B |
|                   ConcurrentDictionary_2_String_ConstIterator |      2.9534 ns |   0.0151 ns |      2.9260 ns |      2.9751 ns |       0 B |
|  ConcurrentDictionary_2_String_ConstIterator_OperatorOverload |      7.1393 ns |   0.0318 ns |      7.0878 ns |      7.1853 ns |       0 B |
|                      ConcurrentDictionary_2_String_Enumerator | 17,694.5272 ns | 122.0444 ns | 17,505.4187 ns | 17,913.7411 ns |      36 B |

---

**`ConcurrentDictionary<T, U>` - 500 iterations - `Iterator<T, U>`**

|                                                   Method |           Mean |     StdDev |            Min |            Max | Allocated |
|--------------------------------------------------------- |---------------: |-----------: |---------------: |---------------: |----------: |
|                  ConcurrentDictionary_2_Integer_Iterator |      2.6447 ns |  0.0059 ns |      2.6342 ns |      2.6550 ns |       0 B |
| ConcurrentDictionary_2_Integer_Iterator_OperatorOverload |      7.6189 ns |  0.0468 ns |      7.5534 ns |      7.7044 ns |       0 B |
|                ConcurrentDictionary_2_Integer_Enumerator |  6,779.7054 ns | 34.0296 ns |  6,738.9984 ns |  6,861.9105 ns |      36 B |
|                   ConcurrentDictionary_2_String_Iterator |      2.4121 ns |  0.0119 ns |      2.3976 ns |      2.4355 ns |       0 B |
|  ConcurrentDictionary_2_String_Iterator_OperatorOverload |      7.4956 ns |  0.0607 ns |      7.4268 ns |      7.6157 ns |       0 B |
|                 ConcurrentDictionary_2_String_Enumerator | 17,612.4634 ns | 87.0406 ns | 17,456.0915 ns | 17,793.6418 ns |      36 B |
