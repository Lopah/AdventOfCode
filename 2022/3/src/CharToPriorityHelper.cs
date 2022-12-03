namespace AdventOfCode._2022.Day3;

public static class CharToPriorityHelper
{
    public static int GetPriorityFromChar(char input)
    {
        var encodedInput = (int)input;
        if (char.IsUpper(input))
        {
            encodedInput += 26;
        }
        else
        {
            encodedInput -= 32;
        }

        encodedInput -= 64;

        return encodedInput;
    }
}
