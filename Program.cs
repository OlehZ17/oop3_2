using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введiть перший рядок:");
        string firstString = Console.ReadLine();

        Console.WriteLine("Введiть другий рядок:");
        string secondString = Console.ReadLine();

        // Визначення довжини рядків та порівняння
        int firstStringLength = GetStringLenghth(firstString);
        int secondStringLength = GetStringLenghth(secondString);

        Console.WriteLine("Довжина першого рядка: " + firstStringLength);
        Console.WriteLine("Довжина другого рядка: " + secondStringLength);

        CompareStrings(firstString, secondString);

        // Об'єднання рядків
        string concatenatedString = ConcatenateStrings(firstString, secondString);
        Console.WriteLine("Результат об'єднання рядкiв: " + concatenatedString);

        // Опрацювання першого рядка
        int plusMinusEqualCount = CountSymbols(firstString, '+', '-', '=');
        Console.WriteLine("Загальне число входжень символiв '+', '-', '=' у перший рядок: " + plusMinusEqualCount);

        string replacedString = ReplaceSymbols(firstString, '+', '-', '=', "**");
        Console.WriteLine("Рядок зi заміненими символами '+', '-', '=': " + replacedString);

        // Опрацювання другого рядка
        int letterACount = CountLettersInLastWord(secondString, 'a');
        Console.WriteLine("Кiлькiсть букв 'а' в останньому словi другого рядка: " + letterACount);
    }

    static int GetStringLenghth(string inputString)
    {
        return inputString.Length;
    }

    static void CompareStrings(string firstString, string secondString)
    {
        bool isEqual = firstString == secondString;
        bool isFirstLonger = firstString.Length > secondString.Length;
        bool isSecondLonger = firstString.Length < secondString.Length;

        Console.WriteLine("Порiвняння рядкiв:");

        if (isEqual)
        {
            Console.WriteLine("Рядки рiвнi.");
        }
        else
        {
            Console.WriteLine("Рядки не рiвнi.");
        }

        if (isFirstLonger)
        {
            Console.WriteLine("Перший рядок довший за другий.");
        }
        else if (isSecondLonger)
        {
            Console.WriteLine("Другий рядок довший за перший.");
        }
        else
        {
            Console.WriteLine("Рядки мають однакову довжину.");
        }
    }

    static string ConcatenateStrings(string firstString, string secondString)
    {
        return firstString + secondString;
    }

    static int CountSymbols(string inputString, params char[] symbols)
    {
        int count = 0;
        foreach (char symbol in symbols)
        {
            count += inputString.Split(symbol).Length - 1;
        }
        return count;
    }

    static string ReplaceSymbols(string inputString, char oldSymbol1, char oldSymbol2, char oldSymbol3, string newSymbols)
    {
        return inputString.Replace(oldSymbol1.ToString(), newSymbols)
                          .Replace(oldSymbol2.ToString(), newSymbols)
                          .Replace(oldSymbol3.ToString(), newSymbols);
    }

    static int CountLettersInLastWord(string inputString, char letter)
    {
        string[] words = inputString.Split(' ');
        string lastWord = words[words.Length - 1];

        int count = 0;
        foreach (char character in lastWord)
        {
            if (character == letter)
            {
                count++;
            }
        }
        return count;
    }
}

