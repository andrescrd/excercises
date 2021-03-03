using System.Linq;

public static class Triangle
{
    // 10,2,5,1,8,20
    // 1 2 5 8 10 20

    // 0 2 4

    // 10 5 8


    // 10,50,5,1
    // 1 5 10 50
    public static int Solution(int[] A)
    {
        if (A.Length < 3)
            return 0;

        var sortedA = A.OrderBy(r => r).ToArray();

        for (int i = 0; i < sortedA.Length - 2; i++)
        {
            if (IsTriangle(sortedA[i], sortedA[i +1], sortedA[i+2]))
                return 1;
        }

        return 0;
    }

    public static bool IsTriangle(int A, int B, int C)
    {
        return A + B > C && B + C > A && C + A > B;
    }
}