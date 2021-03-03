using System.Collections.Generic;

public static class PassingCars
{
    public static int Solution(int[] A)
    {
        var passing = 0;
        var eastCar = 0;
        
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] == 0)
            {
                eastCar++;
            }
            else
            {
                passing += eastCar;

                if (passing > 1e9)
                    return -1;
            }
        }

        return passing;
    }
}