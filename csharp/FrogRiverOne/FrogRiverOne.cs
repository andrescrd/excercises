using System.Collections.Generic;

public static class FrogRiverOne
{
    public static int Solution(int X, int[] A)
    {
        var sorted = new Dictionary<int, bool>();
        
        for (int i = 0; i < A.Length; i++)
        {
            if(sorted.ContainsKey(A[i]))
                continue;
                        
            sorted.Add(A[i],true);
            if (sorted.Count == X) return i;
        }

        return -1;
    }
}