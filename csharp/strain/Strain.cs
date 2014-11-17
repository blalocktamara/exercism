using System;
using System.Collections.Generic;

public static class Strain
{

    public static LinkedList<int> Keep (this LinkedList<int> input, Func<int, bool> lambda)
    {
        var result = new LinkedList<int>();
        
        foreach(int value in input)
        {
            if(lambda(value))
            {
                result.AddLast(value);
            }
        }

        return result;
    }

    public static LinkedList<int> Discard (this LinkedList<int> input, Func<int, bool> lambda)
    {
        var result = new LinkedList<int>();
        
        foreach(int value in input)
        {
            if(lambda(value) == false)
            {
                result.AddLast(value);
            }
        }

        return result;
    }

    public static HashSet<int> Keep (this HashSet<int> input, Func<int, bool> lambda)
    {
        var result = new HashSet<int> {};

        foreach(int value in input)
        {
            if(lambda(value))
            {
                result.Add(value);
            }
        }

        return result;
    }

    public static HashSet<int> Discard (this HashSet<int> input, Func<int, bool> lambda)
    {
        var result = new HashSet<int> {};

        foreach(int value in input)
        {
            if(lambda(value) == false)
            {
                result.Add(value);
            }
        }

        return result;
    }

    public static int[] Keep (this int[] input, Func<int, bool> lambda)
    {
        var result = new List<int> {};

        foreach(int value in input)
        {
            if(lambda(value))
            {
                result.Add(value);
            }
        }

        return result.ToArray();
    }

    public static int[] Discard (this int[] input, Func<int, bool> lambda)
    {
        var result = new List<int> {};

        foreach(int value in input)
        {
            if(lambda(value) == false)
            {
                result.Add(value);
            }
        }

        return result.ToArray();
    }

    public static List<int> Keep (this List<int> input, Func<int, bool> lambda)
    {
        var result = new List<int> {};
        
        foreach(int value in input)
        {
            if(lambda(value))
            {
                result.Add(value);
            }
        }

        return result;
    }

    public static List<int> Discard (this List<int> input, Func<int, bool> lambda)
    {
        var result = new List<int> {};
        
        foreach(int value in input)
        {
            if(lambda(value) == false)
            {
                result.Add(value);
            }
        }

        return result;
    }

    public static string[] Keep (this string[] input, Func<string, bool> lambda)
    {
        var result = new List<string> {};
        
        foreach(string value in input)
        {
            if(lambda(value))
            {
                result.Add(value);
            }
        }

        return result.ToArray();
    }

    public static string[] Discard (this string[] input, Func<string, bool> lambda)
    {
        var result = new List<string> {};
        
        foreach(string value in input)
        {
            if(lambda(value) == false)
            {
                result.Add(value);
            }
        }

        return result.ToArray();
    }

    public static int[][] Keep (this int[][] input, Func<int[], bool> lambda)
    {
        var result = new List<int[]> {};

        foreach(int[] value in input)
        {
            if(lambda(value))
            {
                result.Add(value);
            }
        }

        return result.ToArray();
    }

    public static int[][] Discard (this int[][] input, Func<int[], bool> lambda)
    {
        var result = new List<int[]> {};

        foreach(int[] value in input)
        {
            if(lambda(value) == false)
            {
                result.Add(value);
            }
        }

        return result.ToArray();
    }

}