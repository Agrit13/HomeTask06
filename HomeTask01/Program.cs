// Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

using System;


        char[,] charArray = {
            {'H', 'e', 'l', 'l', 'o'},
            {'W', 'o', 'r', 'l', 'd'}
        };

        Console.WriteLine("Исходный массив символов:");
        PrintCharArray(charArray);

        string resultString = ConvertCharArrayToString(charArray);

        Console.WriteLine("\nСтрока, созданная из символов массива:");
        Console.WriteLine(resultString);
    

    static string ConvertCharArrayToString(char[,] array)
    {
        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);

        char[] charArray = new char[numRows * numCols];
        int index = 0;

        for (int row = 0; row < numRows; row++)
        {
            for (int col = 0; col < numCols; col++)
            {
                charArray[index++] = array[row, col];
            }
        }

        return new string(charArray);
    }

    static void PrintCharArray(char[,] array)
    {
        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);

        for (int row = 0; row < numRows; row++)
        {
            for (int col = 0; col < numCols; col++)
            {
                Console.Write($"{array[row, col]} ");
            }
            Console.WriteLine();
        }
    }

