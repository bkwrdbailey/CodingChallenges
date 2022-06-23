namespace Solutions;
public static class SherlockAndSquares
{

    public static int Solve(int startVal, int endVal)
    {
        var watch = new System.Diagnostics.Stopwatch();

        watch.Start();

        int number = 1;
        int totalNum = 0;

        while (true)
        {
            if (startVal < (number * number) && (number * number) <= endVal)
            {
                totalNum++;
            }
            else if ((number * number) > endVal)
            {
                break;
            }
            number++;
        }

        watch.Stop();

        Console.WriteLine(watch.Elapsed + " Inner Method Elapsed Time");

        return totalNum;
    }
}