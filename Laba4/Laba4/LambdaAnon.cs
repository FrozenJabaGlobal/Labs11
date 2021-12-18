using System;

namespace Prog
{
    delegate int SumCount(int[,] data);
    static class LambdaAnonymous
    {
        static int GetSum(int[,] data)
        {
            int sum = 0;
            int[] res = new int[2];
            for (int i = 0; i < data.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < data.GetUpperBound(1) + 1; j++)
                {
                    res[i] += data[i, j];
                    sum = res[i];
                }

            }
            return sum;
        }

        public static SumCount CountAnonymousFunction = delegate (int[,] data)
        {
            return GetSum(data);
        };

        public static SumCount CountLambda = (data) => GetSum(data);
    }
}