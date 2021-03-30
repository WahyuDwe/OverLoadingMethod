using System;
using System.Linq;

namespace LatihanOverloadingMethod
{
    public class Numbers
    {
        public int FindMinimum(int number1, int number2) => (new int[] { number1, number2 }).Min();

        public float FindMinimum(int number1, int number2, float number3) => (new float[] { number1, number2, number3 }).Min();
        public int FindMaximum(int number1, int number2) => (new int[] { number1, number2 }).Max();
        public float FindMaximum(int number1, int number2, float number3) => (new float[] { number1, number2, number3 }).Max();
    }

}