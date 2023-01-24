// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// ​
// m = 3, n = 4.
// ​
// 0,5 7 -2 -0,2
// ​
// 1 -3,3 8 -9,9
// ​
// 8 7,8 -7,1 9

// создаем метод формирования случайных вещественных чисел c диапазоном от -100.0 до 100.0

const int a = -100;
const int b = 100;
double[ , ] CreateArray (int row, int column) 

{


double[,] massiveRandom = new double[row, column];

for (int i = 0; i < massiveRandom.GetLength(0); i++) 
        {
            for (int j = 0; j < massiveRandom.GetLongLength(1); j++) 
            {
            
                var numberRand = new Random();
                int rd = numberRand.Next(-a, b);               
                massiveRandom[i, j] = rd * new Random().NextDouble();

            }

        } 



return massiveRandom;
}

// метод печати элементов массива

void Printmassive(double[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(mass[i, j],1)}    ");
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Внесите размерность массива - количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Внесите размерность массива - количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());


double[,] arr = CreateArray(m, n);
Console.WriteLine();
Printmassive(arr);