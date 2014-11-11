using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Phrase
{

    private string phrase;

    public Phrase ()
    {

    }

    public Phrase (string phrase)
    {
        this.phrase = phrase;
    }

    public Dictionary<string,int> WordCount ()
    {
        // Create result
        Dictionary<string,int> result = new Dictionary<string,int> {};

        // Find words
        //  \w      Starts with character. 
        //  [\w'-]* May contain characters, single quotes and dashes
        //  (?<!'') Does not end with a single quote
        Match words = Regex.Match(phrase, @"\w[\w'-]*(?<!')");

        //  Loop words
        while(words.Success)
        {
            //  Convert to lowercase
            string word = words.Value.ToLower();

            // Update count
            int value = 0;
            result.TryGetValue(word, out value);
            result[word] = value + 1;

            // Next word
            words = words.NextMatch();
        }

        // Done
        return result;
    }

}