### Iterator Benchmarks - `Dictionary<T, U>`

``` ini
BenchmarkDotNet=v0.10.1, OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i5-2500K CPU 3.30GHz, ProcessorCount=4
Frequency=3233206 Hz, Resolution=309.2905 ns, Timer=TSC
  [Host]     : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.6.1586.0 [AttachedDebugger]
  DefaultJob : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.6.1586.0

Allocated=0 B  
```

---

**`Dictionary<T, U>` - 500 iterations - `ConstIterator<T, U>`**

|                                              Method |          Mean |     StdDev |           Min |           Max |
|---------------------------------------------------- |--------------: |-----------: |--------------: |--------------: |
|                  Dictionary_2_Integer_ConstIterator |     2.9833 ns |  0.0172 ns |     2.9497 ns |     3.0168 ns |
| Dictionary_2_Integer_ConstIterator_OperatorOverload |     7.0891 ns |  0.0424 ns |     7.0243 ns |     7.1769 ns |
|                     Dictionary_2_Integer_Enumerator | 4,049.7120 ns | 12.7141 ns | 4,030.9359 ns | 4,073.2453 ns |
|                   Dictionary_2_String_ConstIterator |     2.9765 ns |  0.0126 ns |     2.9571 ns |     3.0042 ns |
|  Dictionary_2_String_ConstIterator_OperatorOverload |     7.0517 ns |  0.0379 ns |     6.9836 ns |     7.1152 ns |
|                      Dictionary_2_String_Enumerator | 5,614.4641 ns | 34.1495 ns | 5,570.0335 ns | 5,675.9746 ns |

---

**`Dictionary<T, U>` - 500 iterations - `Iterator<T, U>`**

|                                         Method |          Mean |     StdDev |           Min |           Max |
|----------------------------------------------- |--------------: |-----------: |--------------: |--------------: |
|                  Dictionary_2_Integer_Iterator |     3.0247 ns |  0.0499 ns |     2.9732 ns |     3.1248 ns |
| Dictionary_2_Integer_Iterator_OperatorOverload |     7.0921 ns |  0.0319 ns |     7.0484 ns |     7.1644 ns |
|                Dictionary_2_Integer_Enumerator | 4,051.7638 ns | 13.8890 ns | 4,029.3760 ns | 4,076.0319 ns |
|                   Dictionary_2_String_Iterator |     2.9623 ns |  0.0082 ns |     2.9498 ns |     2.9742 ns |
|  Dictionary_2_String_Iterator_OperatorOverload |     7.0390 ns |  0.0208 ns |     7.0015 ns |     7.0676 ns |
|                 Dictionary_2_String_Enumerator | 5,598.9697 ns | 21.0608 ns | 5,572.9243 ns | 5,637.9340 ns |
