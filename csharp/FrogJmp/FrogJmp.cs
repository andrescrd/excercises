public static class FrogJmp
{
    public static int Solution(int x, int y, int d)
    {
        var distance = y - x;
        return (distance + d - 1) / d;
    }
}