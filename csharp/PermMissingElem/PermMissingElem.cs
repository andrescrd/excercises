using System.Linq;

public static class PermMissingElem
{
    public static int Solution(int[] a)
    {
        if (a.Length <= 0) return 0;
        
        var size = a.Length + 1;
        var sum = size * (1 + size) / 2; //https://en.wikipedia.org/wiki/Arithmetic_progression#Sum
        var aSum = 0;

        for (int i = 0; i < a.Length; i++)
            aSum += a[i];

        return sum - aSum;
    }
}