using System;
using System.Collections.Generic;

public class DNA
{
    public Dictionary<char, int> NucleotideCounts;
    private string nucleotides;
    public string Nucleotides
    {
        get { return nucleotides; }
        set
        {
            nucleotides = value;
            parseNucleotides();
        }
    }

    public DNA ()
    {
        Nucleotides = "";
    }
    
    public DNA (string nucleotides)
    {
        Nucleotides = nucleotides;
    }

    public int Count (char nucleotide)
    {
        try
        {
            return NucleotideCounts[nucleotide];
        }
        catch (Exception ex)
        {
            // Throw custom exception
            throw new InvalidNucleotideException(ex.Message);
        }

    }

    private void parseNucleotides ()
    {
        NucleotideCounts = new Dictionary<char, int> { { 'A', 0 }, { 'T', 0 }, { 'C', 0 }, { 'G', 0 } };

        foreach (char nucleotide in Nucleotides)
        {
            NucleotideCounts[nucleotide]++;

        }
    }

}

public class InvalidNucleotideException : Exception
{
    public override string Message
    {
        get
        {
            return "Nucleotides are A, T, C and G.";
        }
    }

    public InvalidNucleotideException ()
    {

    }

    public InvalidNucleotideException (string message)
    {

    }
}