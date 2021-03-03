using System.Collections.Generic;

public static class Distinct
{
    public static int Solution(int[] A)
    {
        var hash = new HashSet<int>(A);
        return hash.Count;
    }
}