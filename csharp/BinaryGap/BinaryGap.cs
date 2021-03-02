using System;

public static class BinaryGap
{
    public static int Solution(int n)
    {
        if (n <= 0)
            return 0;

        int gap = 0;
        int maxGap = 0;
        var binary = Convert.ToString(n, 2).ToCharArray();

        for (int i = 1; i < binary.Length; i++)
        {
            if (binary[i] == '1')
            {
                if (gap > maxGap)
                    maxGap = gap;
                
                gap = 0;
            }
            else
            {
                gap++;
            }
        }

        return maxGap;
    }
}