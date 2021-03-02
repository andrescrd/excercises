public static class CyclicRotation
{
    public static int[] Solution(int[] a, int k)
    {
        if (a.Length <= 0 || k <= 0)
            return a;

        var b = new int[a.Length];
        b[0] = a[^1];

        for (int i = 0; i < a.Length - 1; i++)
            b[i + 1] = a[i];

        return k > 1 ? Solution(b, k - 1) : b;
    }
}