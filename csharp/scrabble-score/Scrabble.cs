using System.Collections.Generic;

public class Scrabble
{
	public string LettersToPlay;
	public static Dictionary<char, int> LetterValues = new Dictionary<char, int> {
		{'A', 1},
		{'E', 1},
		{'I', 1},
		{'O', 1},
		{'U', 1},
		{'L', 1},
		{'N', 1},
		{'R', 1},
		{'S', 1},
		{'T', 1},
		{'D', 2},
		{'G', 2},
		{'B', 3},
		{'C', 3},
		{'M', 3},
		{'P', 3},
		{'F', 4},
		{'H', 4},
		{'V', 4},
		{'W', 4},
		{'Y', 4},
		{'K', 5},
		{'J', 8},
		{'X', 8},
		{'Q', 10},
		{'Z', 10} };

	public Scrabble (string lettersToPlay)
	{
		LettersToPlay = lettersToPlay;
	}

	public int Score ()
	{
		return Score(LettersToPlay);
	}

	public static int Score (string letters)
	{
		int result = 0;
		int score = 0;

		letters = letters ?? "";

		foreach (char letter in letters.ToUpper())
		{
			LetterValues.TryGetValue(letter, out score);
			result += score;
		}

		return result;
	}
}