### Iterator Benchmarks - `SortedList`

``` ini
BenchmarkDotNet=v0.10.1, OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i5-2500K CPU 3.30GHz, ProcessorCount=4
Frequency=3233206 Hz, Resolution=309.2905 ns, Timer=TSC
  [Host]     : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.6.1586.0 [AttachedDebugger]
  DefaultJob : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.6.1586.0

Allocated=0 B  
```

---

**`SortedList` - 500 iterations - `ConstIterator`**

|                                            Method |           Mean |     StdDev |            Min |            Max |  Gen 0 | Allocated |
|-------------------------------------------------- |---------------: |-----------: |---------------: |---------------: |-------: |----------: |
|                  SortedList_Integer_ConstIterator |      2.5989 ns |  0.0256 ns |      2.5623 ns |      2.6645 ns |      - |       0 B |
| SortedList_Integer_ConstIterator_OperatorOverload |      7.4411 ns |  0.0451 ns |      7.3271 ns |      7.5009 ns |      - |       0 B |
|                     SortedList_Integer_Enumerator | 10,432.0244 ns | 68.3206 ns | 10,284.0115 ns | 10,536.7542 ns | 2.2074 |   8.04 kB |
|                   SortedList_String_ConstIterator |      2.6080 ns |  0.0173 ns |      2.5864 ns |      2.6442 ns |      - |       0 B |
|  SortedList_String_ConstIterator_OperatorOverload |      7.4593 ns |  0.0258 ns |      7.4223 ns |      7.5083 ns |      - |       0 B |
|                      SortedList_String_Enumerator | 10,472.1229 ns | 50.1617 ns | 10,373.6838 ns | 10,556.0320 ns | 2.2156 |   8.04 kB |

---

**`SortedList` - 500 iterations - `Iterator`**

|                                       Method |           Mean |     StdDev |            Min |            Max |  Gen 0 | Allocated |
|--------------------------------------------- |---------------: |-----------: |---------------: |---------------: |-------: |----------: |
|                  SortedList_Integer_Iterator |      2.5916 ns |  0.0145 ns |      2.5595 ns |      2.6151 ns |      - |       0 B |
| SortedList_Integer_Iterator_OperatorOverload |      7.4400 ns |  0.0162 ns |      7.4073 ns |      7.4592 ns |      - |       0 B |
|                SortedList_Integer_Enumerator | 10,406.4578 ns | 72.2061 ns | 10,311.8490 ns | 10,532.0750 ns | 2.2074 |   8.04 kB |
|                   SortedList_String_Iterator |      2.6017 ns |  0.0174 ns |      2.5718 ns |      2.6410 ns |      - |       0 B |
|  SortedList_String_Iterator_OperatorOverload |      7.4501 ns |  0.0417 ns |      7.3930 ns |      7.5377 ns |      - |       0 B |
|                 SortedList_String_Enumerator | 10,452.3065 ns | 51.2653 ns | 10,376.5633 ns | 10,547.4999 ns | 2.2156 |   8.04 kB |
