public static class CountDiv
{
    //4* 5 6 7 8 9 10 11 12
    public static int Solution(int A, int B, int K)
    {
       var inclusive = (A % K == 0) ? 1 : 0;
        return  (B - (A - A % K)) / K + inclusive ; 
    }
}