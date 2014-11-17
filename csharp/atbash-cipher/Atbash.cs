using System;
using System.Text;

public static class Atbash
{
	public static string Encode (string input)
	{
		var sb = new StringBuilder();

		int count = 0;
		foreach (char letter in input.ToLower())
		{
			if(Char.IsLetter(letter) == false
			&& Char.IsNumber(letter) == false)
			{
				continue;
			}

			if(Char.IsLetter(letter))
			{
				sb.Append((char)('z' - letter + 'a'));
			}
			else if(Char.IsNumber(letter))
			{
				sb.Append(letter);
			}

			count++;
			if(count == 5)
			{
				sb.Append(" ");
				count = 0;
			}
		}

		return sb.ToString().Trim();
	}
}