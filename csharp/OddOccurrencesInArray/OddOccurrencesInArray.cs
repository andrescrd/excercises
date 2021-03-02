public static class OddOccurrencesInArray
{
    public static int Solution(int[] a)
    {
        var result = 0;

        for (int i = 0; i < a.Length; i++)
            result ^= a[i];

        return result;
    }
}