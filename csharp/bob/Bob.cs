using System;
                    
public class Bob
{
    public static void Main()
    {}

    public Bob()
    {}

    public string Hey(string phrase)
    {
        // Are you shouting?
        if(String.Compare(phrase, phrase.ToUpper()) == 0
        && String.Compare(phrase, phrase.ToLower()) != 0)
        {
            return "Whoa, chill out!";
        }

        // Asking a question?
        if(phrase.EndsWith("?"))
        {
            return "Sure.";
        }

        // Did I hear something?
        if(phrase.Trim().Length == 0)
        {
            return "Fine. Be that way!";
        }

        // Default
        return "Whatever."; 
    }
    
}