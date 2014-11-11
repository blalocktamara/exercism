using System;
using System.Collections.Generic;

public class Anagram
{

    private string BaseValue;
    private string BaseSorted;

    public string Base {
        get { return BaseValue; }
        set 
        {
            BaseValue = value; 
            var sortedValue = value.ToLower().ToCharArray();
            Array.Sort<char>(sortedValue); 
            BaseSorted = new string(sortedValue); 
        }
    }

    public Anagram ()
    {

    }

    public Anagram (string input)
    {
        Base = input;
    }

    public string[] Match (string[] words)
    {
        // Create Result
        var result = new List<string> {};

        // Loop Words
        foreach(string word in words)
        {
            // Simple Checks
            if (word.Length != Base.Length
            || String.Compare(word, BaseValue, true) == 0) {
                // Skip
                continue;
            }

            // Sort Characters
            var wordArray = word.ToLower().ToCharArray();
            Array.Sort<char>(wordArray);

            // Final Check
            if (String.Compare(new string(wordArray), BaseSorted, true) == 0)
            {
                // Add Word
                result.Add(word);
            }

        }

        // Return
        return result.ToArray();
    }

}