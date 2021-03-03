public static class MaxCounters
{
    public static int[] Solution(int N, int[] A)
    {
        var maxValue = 0;
        var counters = new int[N];

        FillCounter(counters,0);
    
        for (var i = 0; i < A.Length; i++)
        {
            if (A[i] > N)
            {
                FillCounter(counters, maxValue);
            }
            else
            {               
                counters[A[i] - 1]++;
                
                if (counters[A[i] - 1] > maxValue)
                    maxValue = counters[A[i] - 1];
            }
        }        
        
        return counters;
    }

    private static void FillCounter(int[] counters, int value)
    {
        for (int i = 0; i < counters.Length; i++)
            counters[i] = value;
    }
}