using System;

public class PhoneNumber
{
    public string number;
    public string Number
    {
        get { return number; }
        set
        {
            foreach (char digit in value.ToCharArray())
            {
                if(Char.IsNumber(digit))
                {
                    number+= digit;
                }
            }

            if(number.Length == 11
            && number[0] == '1')
            {
                number = number.Substring(1, number.Length - 1);
            }

            if(number.Length != 10)
            {
                number = "0000000000";
            }
        }
    }
    public string AreaCode
    {
        get { return number.Substring(0, 3); }
    }

    public PhoneNumber ()
    {
        Number = "0000000000";
    }

    public PhoneNumber (string number)
    {
        Number = number;
    }

    public override string ToString ()
    {
        string result = "";
        result+= "(";
        result+= Number.Substring(0, 3);
        result+= ") ";
        result+= Number.Substring(3, 3);
        result+= "-";
        result+= Number.Substring(6, 4);
        
        return result;
    }

}