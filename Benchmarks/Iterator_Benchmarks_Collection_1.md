### Iterator Benchmarks - `Collection<T>`

``` ini
BenchmarkDotNet=v0.10.1, OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i5-2500K CPU 3.30GHz, ProcessorCount=4
Frequency=3233206 Hz, Resolution=309.2905 ns, Timer=TSC
  [Host]     : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.6.1586.0 [AttachedDebugger]
  DefaultJob : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.6.1586.0

Allocated=0 B  
```

---

**`Collection<T>` - 500 iterations - `ConstIterator<T>`**

|                                              Method |          Mean |     StdDev |           Min |           Max | Allocated |
|---------------------------------------------------- |--------------: |-----------: |--------------: |--------------: |----------: |
|                  Collection_1_Integer_ConstIterator |     2.8761 ns |  0.0310 ns |     2.8337 ns |     2.9435 ns |       0 B |
| Collection_1_Integer_ConstIterator_OperatorOverload |     7.5560 ns |  0.0542 ns |     7.4644 ns |     7.6694 ns |       0 B |
|                     Collection_1_Integer_Enumerator | 3,714.1396 ns | 48.0812 ns | 3,646.5163 ns | 3,807.9150 ns |      24 B |
|                   Collection_1_String_ConstIterator |     2.6664 ns |  0.0446 ns |     2.5877 ns |     2.7534 ns |       0 B |
|  Collection_1_String_ConstIterator_OperatorOverload |     7.7129 ns |  0.0529 ns |     7.6441 ns |     7.8083 ns |       0 B |
|                      Collection_1_String_Enumerator | 5,167.7270 ns | 15.1720 ns | 5,138.6653 ns | 5,198.6867 ns |      24 B |

---

**`Collection<T>` - 500 iterations - `Iterator<T>`**

|                                         Method |          Mean |     StdDev |           Min |           Max | Allocated |
|----------------------------------------------- |--------------: |-----------: |--------------: |--------------: |----------: |
|                  Collection_1_Integer_Iterator |     2.8785 ns |  0.0168 ns |     2.8547 ns |     2.9058 ns |       0 B |
| Collection_1_Integer_Iterator_OperatorOverload |     7.4734 ns |  0.0462 ns |     7.4084 ns |     7.5481 ns |       0 B |
|                Collection_1_Integer_Enumerator | 3,687.5537 ns | 12.7145 ns | 3,667.0356 ns | 3,711.5301 ns |      24 B |
|                   Collection_1_String_Iterator |     2.5867 ns |  0.0507 ns |     2.5382 ns |     2.6871 ns |       0 B |
|  Collection_1_String_Iterator_OperatorOverload |     7.5018 ns |  0.0305 ns |     7.4626 ns |     7.5643 ns |       0 B |
|                 Collection_1_String_Enumerator | 5,094.1220 ns | 18.5608 ns | 5,065.9290 ns | 5,125.9787 ns |      24 B |
