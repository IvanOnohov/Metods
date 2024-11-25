using System;
using ClassLibrary1;

class Методы
{
    static void Main(string[] args)
    {
         
        int a = 5;
        int b = 10;
        int c = Class1.Sat(a,b) ;
        Console.WriteLine("Результат: "+c);
        Console.WriteLine();
        int rows = 3; 
        int columns = 3;  

        int[,] array = massiv(rows, columns);
        PrintArray(array);


        static int[,] massiv(int rows, int columns)
        {
            int[,] array = new int[rows, columns];
            Random rand = new Random();

            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = rand.Next(1, 100); 
                }
            }

            return array;
        }

        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t"); 
                }
                Console.WriteLine(); 
            }
        }
        
    }
}
