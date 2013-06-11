using System;

namespace YieldReturnDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new PrimeCalculator();

			Console.WriteLine("Example 1:");
			var example1 = new Example1(calculator);
            example1.Run();

			Console.WriteLine("Example 2:");
			var example2 = new Example2(calculator);
            example2.Run();

			Console.WriteLine("Example 3:");
			var example3 = new Example3(calculator);
            example3.Run();

			Console.WriteLine("Press <enter> to exit.");
			Console.ReadLine();
		}
    }
}
