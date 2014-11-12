using System;
using System.Collections.Generic;

public class Allergies
{

    public static Dictionary<int, string> Allergines = new Dictionary<int, string> {
        {1, "eggs"},
        {2, "peanuts"},
        {4, "shellfish"},
        {8, "strawberries"},
        {16, "tomatoes"},
        {32, "chocolate"},
        {64, "pollen"},
        {128, "cats"} };

    public int Count;

    public Allergies (int count)
    {
        Count = count;
    }

    public bool AllergicTo(string allergy)
    {
        foreach(string item in List())
        {
            if(String.Compare(item, allergy) == 0)
            {
                return true;
            }
        }

        return false;
    }

    public List<string> List ()
    {
        List<string> result = new List<string> {};

        char[] binary = Convert.ToString(Count, 2).ToCharArray();
        Array.Reverse(binary);

        for(int power = 0; power < binary.Length; power++)
        {
            int key = (int)Math.Pow(2, power);
            if(binary[power] == '1' && Allergines.ContainsKey(key))
            {
                result.Add(Allergines[key]);
            }
        }

        return result;
    }

}