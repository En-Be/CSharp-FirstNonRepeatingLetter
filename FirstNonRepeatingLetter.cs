using System;

class Program
{
    static void Main(string[] args)
    {
        FirstNonRepeatingLetter firstNRP = new FirstNonRepeatingLetter(args[0]);
    }
}

class FirstNonRepeatingLetter
{
    char[] characters;
    static string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    char[] letters = alphabet.ToCharArray();

    string result = "";
    
    public FirstNonRepeatingLetter(string input)
    {
        GuardClauses(input);
        result = FindFirstNonRepeater();
        Console.WriteLine(Result());
    }
    
    private void GuardClauses(string input)
    {
        characters = new char[input.Length];
        
        try
        {
            characters = input.ToCharArray();
        }
        catch
        {
            throw new ArgumentException("Input must be a string of letters");
        }

        foreach(char character in characters)
        {
            if(Array.Exists(letters, element => element == character))
            {
            }
            else
            {
                throw new ArgumentException("Input must be in the alphabet");
            }
        }
    }

    private string FindFirstNonRepeater()
    {
        for(int c = 0; c < characters.Length; c++)
        {
            string[] trimmedArray = new string[characters.Length];
            for(int tc = 0; tc < characters.Length; tc++)
            {
                char newChar = characters[tc];
                trimmedArray[tc] = newChar.ToString().ToLower();
            }

            trimmedArray[c] = "0";
            if(Array.Exists(trimmedArray, element => element == characters[c].ToString().ToLower()))
            {
            }
            else
            {
                return characters[c].ToString();
            }
        }

        return "";
    }

    public string Result()
    {
        return result;
    }
}