namespace Iterators.Examples
{
    using RangeIt.Iterators;
    using System;
    using System.Collections.Generic;

    internal static class IteratorExamples
    {
        internal static void Main(string[] args)
        {
            Iterator();
            ConstIterator();
            AdvanceAndRetreat();
        }

        internal static void Iterator()
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };
            Iterator<int> it = list.Begin();

            Console.WriteLine("Looping forward:");

            while (it++)
                Console.WriteLine(it.Current);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Looping backward:");

            while (--it)
                Console.WriteLine(it.Current);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Looping forward with enumerator:");

            it = list.Begin();

            foreach (int val in it)
                Console.WriteLine(val);
        }

        internal static void ConstIterator()
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine("------------------------------------");
            Console.WriteLine("---------- Const iterator ----------");
            Console.WriteLine("------------------------------------");

            ConstIterator<int> constIt = list.ConstBegin();

            Console.WriteLine("Looping forward:");

            while (constIt++)
                Console.WriteLine(constIt.Current);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Looping backward:");

            while (--constIt)
                Console.WriteLine(constIt.Current);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Looping forward with enumerator:");

            constIt = list.ConstBegin();

            foreach (int val in constIt)
                Console.WriteLine(val);
        }

        internal static void AdvanceAndRetreat()
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Advance iterator and assign value:");

            Iterator<int> it = list.Begin(); // list = { 1, 2, 3, 4, 5 }
            it += 2; // advance by two positions

            Console.WriteLine($"Before (index = {it.Index}): {it.Current}");
            it.Current = 4;
            // list = { 1, 4, 3, 4, 5 }
            Console.WriteLine($"Before (index = {it.Index}): {it.Current}");

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Retreat iterator and assign value:");

            it = list.End(); // list = { 1, 4, 3, 4, 5 }
            it -= 2; // retreat by two positions

            Console.WriteLine($"Before (index = {it.Index}): {it.Current}");
            it.Current = 7;
            // list = { 1, 4, 3, 7, 5 }
            Console.WriteLine($"Before (index = {it.Index}): {it.Current}");

            Console.ReadKey();
        }
    }
}
