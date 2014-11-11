using System;

public class Robot
{
    public string Name;

    public Robot ()
    {
        Reset();
    }

    public void Reset ()
    {
        Name = "";
        Name += (char)('A' + RandomSingleton.Next(0, 26));
        Name += (char)('A' + RandomSingleton.Next(0, 26));
        Name += RandomSingleton.Next(0, 9);
        Name += RandomSingleton.Next(0, 9);
        Name += RandomSingleton.Next(0, 9);

    }

    public static class RandomSingleton
    {
        private static Random _random = new Random();

        public static int Next(int start, int end)
        {
            return _random.Next(start, end);
        }

    }

}