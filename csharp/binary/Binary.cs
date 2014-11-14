using System;

public class Binary
{
	private string source;
	public string Source {
		get { return source; }
		set
		{
			foreach (char character in value)
			{
				if(character != '0'
				&& character != '1')
				{
					value = "0";
					break;
				}

			}
			source = value;
		}
	}

	public Binary(string binary)
	{
		Source = binary;
	}

	public int ToDecimal ()
	{
		int result = 0;
		int power = 0;

		char[] reversed = source.ToCharArray();
		Array.Reverse(reversed);

		foreach (char digit in reversed)
		{
			if(digit == '1')
			{
				result += (int)Math.Pow(2, power);
			}
			power++;
		}

		return result;
	}


}