using System;
using System.Collections.Generic;

namespace YieldReturnDemo
{
    public class Example1
    {
        private readonly IPrimeCalculator _primeCalculator;

        public Example1(IPrimeCalculator primeCalculator)
        {
            _primeCalculator = primeCalculator;
        }

        public void Run()
        {
            var primeNumbers = GetPrimeNumbers(50);

            foreach (var prime in primeNumbers)
                Console.WriteLine(prime);

            foreach (var prime in primeNumbers)
                Console.WriteLine(prime);

			Console.WriteLine();
		}

		public IEnumerable<ulong> GetPrimeNumbers(ulong maxValue)
        {
			ulong mightBePrime = 2;

            while (mightBePrime <= maxValue)
            {
                if (_primeCalculator.IsPrime(mightBePrime))
                    yield return mightBePrime;

                mightBePrime++;
            }
        }
    }
}
