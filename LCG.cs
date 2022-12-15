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
        private double modulus { set; get; }
        private int numberOfIterations { set; get; }
        private int cycleLength { set; get; }

        public LCG() {
            seed = 0;
            multiplier = 0;
            increment = 0;
            modulus = 0;
            numberOfIterations = 0;
        }
        public LCG(double seed, double multiplier, double increment, double modulus, int numberOfIterations) {
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

        public int cycleLengthAlgo() {
            throw new NotImplementedException();
        }
    }
}
