using System;
using System.Linq;

public static class MaxProductOfThree
{
    public static int Solution(int[] A)
    {
        A = A.OrderBy(r => r).ToArray();
        return Math.Max(A[0] * A[1] * A[^1],A[^3] *A[^2]* A[^1]);
    }
}