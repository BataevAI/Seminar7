// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// ​
// m = 3, n = 4.
// ​
// 0,5 7 -2 -0,2
// ​
// 1 -3,3 8 -9,9
// ​
// 8 7,8 -7,1 9

Console.WriteLine();
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int n = Convert.ToInt32(Console.ReadLine());

double[ , ] CreateArray (int row, int column) 

{

double[,] massiveRandom = new double[row, column];

for (int i = 0; i < massiveRandom.GetLength(0); i++) 
        {
            for (int j = 0; j < massiveRandom.GetLongLength(1); j++) 
            {
                massiveRandom[i, j] = Random.

            }

        } 




return massiveRandom;
}

