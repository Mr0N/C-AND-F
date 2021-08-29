using System;
using Samples.HelloWorldTypeProvider;
using System.Linq;
using System.Diagnostics;

namespace CXANDFX
{
    class MyClass
    {
        public static void Print(int  count)
        {
            foreach (var item in Enumerable.Range(0,count))
            {
                Console.WriteLine(item);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            long C = 0 ;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            MyClass.Print(55);
            stopwatch.Stop();
            C = stopwatch.ElapsedMilliseconds;
            stopwatch.Reset();
            stopwatch.Start();
            MyModule.Print(55);
            stopwatch.Stop();
            Console.Clear();
            Console.WriteLine(@"C#:{0}", C);
            Console.WriteLine("F#:{0}",stopwatch.ElapsedMilliseconds);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
