using System.Collections.Generic;

public static class FrogRiverOne
{
    public static int Solution(int X, int[] A)
    {
        var sorted = new HashSet<int>(); // It is possible to use SortedSet<> and avoid line 11,12
        
        for (int i = 0; i < A.Length; i++)
        {         
            sorted.Add(A[i]);
            if (sorted.Count == X) return i;
        }

        return -1;
    }
}