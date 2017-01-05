namespace Iterator.Performance.Tests
{
    using BenchmarkDotNet.Running;
    using NotConst;
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<ArrayList_Iterator_Vs_Enumerator_Tests>();
            Console.ReadKey();
        }
    }
}
