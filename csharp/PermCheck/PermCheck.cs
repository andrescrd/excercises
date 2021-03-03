using System.Collections.Generic;

public static class PermCheck
{
    public static int Solution(int[] A)
    {
        var order = new HashSet<int>(A);
        
        for (var i = 0; i < A.Length; i++)
        {
            if (!order.Contains(i + 1))
                return 0;
        }

        return 1;
    }
}