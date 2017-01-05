namespace Iterator.Performance.Tests
{
    using BenchmarkDotNet.Running;
    using Const;
    using NotConst;

    public class Program
    {
        public static void Main(string[] args)
        {
            // ArrayList
            BenchmarkRunner.Run<ArrayList_Iterator_Vs_Enumerator_Tests>();
            BenchmarkRunner.Run<ArrayList_ConstIterator_Vs_Enumerator_Tests>();

            // SortedList
            BenchmarkRunner.Run<SortedList_Iterator_Vs_Enumerator_Tests>();
            BenchmarkRunner.Run<SortedList_ConstIterator_Vs_Enumerator_Tests>();

            // Array<T>
            BenchmarkRunner.Run<Array_1_Iterator_Vs_Enumerator_Tests>();
            BenchmarkRunner.Run<Array_1_ConstIterator_Vs_Enumerator_Tests>();

            // List<T>
            BenchmarkRunner.Run<List_1_Iterator_Vs_Enumerator_Tests>();
            BenchmarkRunner.Run<List_1_ConstIterator_Vs_Enumerator_Tests>();

            // Collection<T>
            BenchmarkRunner.Run<Collection_1_Iterator_Vs_Enumerator_Tests>();
            BenchmarkRunner.Run<Collection_1_ConstIterator_Vs_Enumerator_Tests>();
        }
    }
}
