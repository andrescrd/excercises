using System.Linq;

public static class PermMissingElem
{
    public static int Solution(int[] a)
    {
        if (a.Length <= 0) return 0;

        var orderedEnumerable = a.OrderBy(r => r).ToArray();

        for (int i = 0; i < orderedEnumerable.Length; i++)
        {
            if (i + 1 != orderedEnumerable[i])
                return i + 1;
        }

        return 0;
    }
}