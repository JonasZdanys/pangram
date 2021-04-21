using System;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
       int alphabetSize = 26;

        return input
            .ToLower()
            .Distinct()
            .Count(char.IsLetter) == alphabetSize;
    }
}