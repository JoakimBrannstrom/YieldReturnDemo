using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace YieldReturnDemo
{
    public class Example2
    {
        private readonly IPrimeCalculator _primeCalculator;

        public Example2(IPrimeCalculator primeCalculator)
        {
            _primeCalculator = primeCalculator;
        }

        public void Run()
        {
            var timer = new Stopwatch();

            timer.Start();
            var primeNumbers = GetPrimeNumbers().Take(100000);
            timer.Stop();

            Console.WriteLine("Prime-calculation took {0} to complete.", timer.Elapsed);
			Console.WriteLine();
        }

		public IEnumerable<ulong> GetPrimeNumbers()
        {
			ulong mightBePrime = 2;

			while (mightBePrime <= ulong.MaxValue)
            {
                if (_primeCalculator.IsPrime(mightBePrime))
                    yield return mightBePrime;

                mightBePrime++;
            }
        }
    }
}
