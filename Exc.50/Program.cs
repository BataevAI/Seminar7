// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// ​
// Например, задан массив:
// ​
// 1 4 7 2
// ​
// 5 9 2 3
// ​
// 8 4 2 4
// ​
// 1 7 -> такого числа в массиве нет

// метод печати элементов массива

void Printmassive(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write(mass[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

//метод формирования случайного массива

int[ , ] CreateArray (int row, int column, int left, int right) 

{


    int [,] massiveRandom = new int[row, column];

        for (int i = 0; i < massiveRandom.GetLength(0); i++) 
            {
                for (int j = 0; j < massiveRandom.GetLength(1); j++) 
                    {
            
                var rnd = new Random();
                             
                massiveRandom[i, j] = rnd.Next(left, right);

                    }

            } 

return massiveRandom;
}

// Метод поиска элемента в массиве

int SearchElem (int[,] Arr, int a, int b) 

{
    
    int number = Arr[a,b];
    return number;
    
   
}


Console.WriteLine("Внесите размерность массива - количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Внесите размерность массива - количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

const int LEFT = 0;
const int RIGHT= 100;

int[,] arr = CreateArray(m, n, LEFT, RIGHT);

Console.WriteLine();

Printmassive(arr);

Console.WriteLine($"А теперь внесите искомый элемент массива: строку: от 0 до {m - 1}");
int numRow = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"А теперь внесите искомый элемент массива: столбец: от 0 до {n - 1}");
int numCol = Convert.ToInt32(Console.ReadLine());


if (numRow < 0 || numRow >= m || numCol < 0 || numCol >= n)
{
    Console.WriteLine("Такого элемента нет!"); 
}
    else {

Console.WriteLine($" Итоговый элемент: {SearchElem(arr, numRow, numCol)}");
    }  
