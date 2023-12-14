// Задайте произвольную строку. Выясните, является ли она палиндромом.


        string String = "Was it a car or a cat i saw";

        Console.WriteLine("Исходная строка:");
        Console.WriteLine(String);

        bool isPalindrome = IsPalindrome(String);

        if (isPalindrome)
        {
            Console.WriteLine("\nСтрока является палиндромом.");
        }
        else
        {
            Console.WriteLine("\nСтрока не является палиндромом.");
        }
    

    static bool IsPalindrome(string input)
    {
        string lowercaseInput = input.ToLower();

        string cleanedString = new string(lowercaseInput.ToCharArray().Where(c => !Char.IsWhiteSpace(c)).ToArray());

        string reversedString = new string(cleanedString.Reverse().ToArray());

        return cleanedString == reversedString;
    }

