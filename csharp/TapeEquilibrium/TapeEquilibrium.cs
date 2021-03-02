using System;

public static class TapeEquilibrium
{
    public static int Solution(int[] a)
    {
        if (a.Length <= 0)
            return 0;

        var left = a[0];
        var right = 0;

        for (int i = 1; i < a.Length; i++)
            right += a[i];

        var result = Math.Abs(right - left);
        
        for (int i = 1; i < a.Length; i++)
        {
            if (Math.Abs(right - left) < result)
                result = Math.Abs(right - left);
            
            left += a[i];
            right -= a[i];
        }

        return result;
    }
}