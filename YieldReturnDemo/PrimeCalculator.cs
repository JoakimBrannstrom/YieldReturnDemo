using System;

namespace YieldReturnDemo
{
    public interface IPrimeCalculator
    {
		bool IsPrime(ulong mightBePrime);
    }

    public class PrimeCalculator : IPrimeCalculator
    {
        public bool IsPrime(ulong mightBePrime)
        {
            //Get Square root of number and iterate, start from 2
			var check = (ulong)Math.Sqrt(mightBePrime);

			for (ulong j = 2; j <= check; j++)
            {
                if (mightBePrime % j == 0)
                    return false;
            }

            return true;
        }
    }
}
