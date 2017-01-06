### Iterator Benchmarks - `List<T>`

``` ini
BenchmarkDotNet=v0.10.1, OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i5-2500K CPU 3.30GHz, ProcessorCount=4
Frequency=3233206 Hz, Resolution=309.2905 ns, Timer=TSC
  [Host]     : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.6.1586.0 [AttachedDebugger]
  DefaultJob : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.6.1586.0

Allocated=0 B  
```

---

**`List<T>` - 500 iterations - `ConstIterator<T>`**

|                                        Method |          Mean |     StdDev |           Min |           Max |
|---------------------------------------------- |--------------: |-----------: |--------------: |--------------: |
|                  List_1_Integer_ConstIterator |     3.3177 ns |  0.1054 ns |     3.2096 ns |     3.5459 ns |
| List_1_Integer_ConstIterator_OperatorOverload |     6.8621 ns |  0.0110 ns |     6.8443 ns |     6.8840 ns |
|                     List_1_Integer_Enumerator | 1,608.9590 ns |  7.7014 ns | 1,597.8792 ns | 1,623.8925 ns |
|                   List_1_String_ConstIterator |     3.2309 ns |  0.0199 ns |     3.2056 ns |     3.2730 ns |
|  List_1_String_ConstIterator_OperatorOverload |     7.0559 ns |  0.0246 ns |     7.0148 ns |     7.1057 ns |
|                      List_1_String_Enumerator | 2,241.6286 ns | 21.0164 ns | 2,203.2050 ns | 2,277.9249 ns |

---

**`List<T>` - 500 iterations - `Iterator<T>`**

|                                   Method |          Mean |    StdDev |           Min |           Max |
|----------------------------------------- |--------------: |----------: |--------------: |--------------: |
|                  List_1_Integer_Iterator |     3.1122 ns | 0.0295 ns |     3.0813 ns |     3.1877 ns |
| List_1_Integer_Iterator_OperatorOverload |     7.6206 ns | 0.0988 ns |     7.4760 ns |     7.8317 ns |
|                List_1_Integer_Enumerator | 1,589.0566 ns | 4.2367 ns | 1,581.1995 ns | 1,597.3706 ns |
|                   List_1_String_Iterator |     3.1044 ns | 0.0432 ns |     3.0523 ns |     3.2062 ns |
|  List_1_String_Iterator_OperatorOverload |     7.4099 ns | 0.1246 ns |     7.1534 ns |     7.6247 ns |
|                 List_1_String_Enumerator | 2,349.7136 ns | 8.8743 ns | 2,333.8491 ns | 2,368.3479 ns |
