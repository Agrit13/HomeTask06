// Задайте строку, содержащую латинские буквы в обоих регистрах. 
//Сформируйте строку, в которой все заглавные буквы заменены на строчные.


        string inputString = "HeLLo WoRLd";

        Console.WriteLine("Исходная строка:");
        Console.WriteLine(inputString);

        string resultString = ConvertToUpper(inputString);

        Console.WriteLine("\nСтрока с замененными заглавными буквами на строчные:");
        Console.WriteLine(resultString);
    

    static string ConvertToUpper(string input)
    {
        char[] charArray = input.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            if (char.IsUpper(charArray[i]))
            {
                charArray[i] = char.ToLower(charArray[i]);
            }
        }

        return new string(charArray);
    }

