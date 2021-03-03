using System.Collections.Generic;

public static class MissingInteger
{
    public static int Solution(int[] A)
    {
        var sort = new SortedSet<int>();        
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] > 0)
                sort.Add(A[i]);
        }

        var result = 1;

        for (int i = 0; i < sort.Count; i++)
        {
            if (sort.Contains(result))
            {
                result++;
            }
            else
            {
                break;
            }
        }

        return result;
    }
}