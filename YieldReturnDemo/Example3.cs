using System;
using System.Collections.Generic;
using System.Linq;

namespace YieldReturnDemo
{
    public class Example3
    {
        private readonly IPrimeCalculator _primeCalculator;

        public Example3(IPrimeCalculator primeCalculator)
        {
            _primeCalculator = primeCalculator;
        }

        public void Run()
        {
            var primeNumbers = Enumerable.Empty<UInt64>();

            try
            {
                primeNumbers = GetPrimeNumbers().Take(1);
            }
            catch (Exception)
            {
                // We do not want to show exceptions to the user..
                // Let's do some logging and stuff instead
            }

            foreach (var prime in primeNumbers)
                Console.WriteLine(prime);	// <-- Watch out for this!

			Console.WriteLine();
		}

		public IEnumerable<ulong> GetPrimeNumbers()
        {
			ulong mightBePrime = 2;

			while (mightBePrime <= ulong.MinValue)
            {
                if (_primeCalculator.IsPrime(mightBePrime))
                    yield return mightBePrime;

                mightBePrime++;
            }

            throw new OverflowException("Prime calculation could not complete.");
        }
    }
}
