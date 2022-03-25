public static class Extensions
{
    public static int FixedValue(this int value, int min, int max)
    {
        if (value >= min && value <= max)
            return value;
        else if (value > max)
            return max;
        else if (value < min)
            return min;
        else return 1;
    }
}