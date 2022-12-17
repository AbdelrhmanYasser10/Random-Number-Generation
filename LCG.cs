using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class LCG
    {
        private double seed { set;  get; }
        private double multiplier { set; get; }
        private double increment { set; get; }
        private int modulus { set; get; }
        private int numberOfIterations { set; get; }
        private int cycleLength { set; get; }

        public LCG() {
            seed = 0;
            multiplier = 0;
            increment = 0;
            modulus = 0;
            numberOfIterations = 0;
        }
        public LCG(double seed, double multiplier, double increment, int modulus, int numberOfIterations) {
            this.seed = seed;
            this.multiplier = multiplier;
            this.increment = increment;
            this.modulus = modulus;
            this.numberOfIterations = numberOfIterations;
        }

        public List<double> generateRandomeNumbers() {

            List<double> generatedNumbers = new List<double>();
            double previousValue = seed;
            for (int i = 0; i < numberOfIterations; i++) {
                double x = (multiplier * previousValue + increment) % modulus;
                previousValue = x;
                generatedNumbers.Add(x);
            }
            return generatedNumbers;
        }

        public double cycleLengthAlgo()
        {
            //throw new NotImplementedException();
            cycleLength = 0;
            double k = modulus - 1;

            bool isA = false;
            for (int i = 0; i < modulus; i++)
            {
                if (multiplier == 5 + (8 * i) || multiplier == 3 + (8 * i))
                {
                    isA = true;
                    break;
                }
            }

            if (isPowerOfTwo((int)modulus) && increment != 0 && isRelativelyPrime(increment, modulus) && (multiplier-1) % 4 ==0)
            {
                cycleLength = modulus;
            }
            else if (isPowerOfTwo(modulus) && increment == 0 && isOdd(seed) && isA)
            {
                cycleLength = modulus / 4;
            }
            else if (isPrime(modulus) && increment == 0 && isDivisableBy_m(Math.Pow(multiplier, k) - 1))
            {
                cycleLength = modulus - 1;
            }

            return cycleLength;

        }
        private bool isPowerOfTwo(double m)
        {
            return (int)(Math.Ceiling((Math.Log(m) / Math.Log(2)))) == (int)(Math.Floor(((Math.Log(m) / Math.Log(2)))));
        }

        private bool isPrime(double n)
        {
            if (n == 2)
            {
                return true;
            }
            if (n < 2 || n % 2 == 0)
            {
                return false;
            }
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private bool isDivisableBy_m(double number)
        {
            return number % modulus == 0;
        }

        private bool isRelativelyPrime(double c, double m)
        {
            //Two integers are relatively prime (or coprime) if there is no integer greater than one that divides them both 
            double maximun = Math.Max(m, c);
            for (double i = 2; i < maximun; i++)
            {
                if ((c % i == 0) && (m % i == 0))
                {
                    return false;
                }

            }
            return true;
        }

        private bool isOdd(double s)
        {
            return s % 2 != 0;
        }
    }
}
