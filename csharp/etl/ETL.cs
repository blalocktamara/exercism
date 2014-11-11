using System;
using System.Collections.Generic;

public class ETL
{
    public static void Main()
    {}

    public ETL ()
    {

    }

    public static Dictionary<string, int> Transform(Dictionary<int, IList<string>> oldDictionary)
    {
        // Create Result
        var result= new Dictionary<string, int> {};

        // Loop Through Old Dictionary
        foreach(KeyValuePair<int, IList<string>> entry in oldDictionary)
        {
            //  Loop Through IList
            foreach(string letter in entry.Value)
            {
                // Transform
                result.Add(letter.ToLower(), entry.Key);
                
            }

        }

        // Return Result
        return result;
    }

}