// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// ​
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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

// метод печати элементов двухмерного массива

void PrintTwoDimensionArray(int[,] mass)
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

// метод печати элементов одномерного массива

void PrintArray(double[] ars)
{
    foreach (var item in ars)
    {
        Console.Write($"{item:f1} ");
    }

}

// метод подсчета среднего арифметического по столбцам

double[ ] AverageRows (int[,] Arr) 

{

    double sum = 0;
    double [] massive = new double[Arr.GetLength(1)];

        for (int k = 0; k < Arr.GetLength(1); k++) 

     
            {
                for (int i = 0; i < Arr.GetLength(0); i++) 
                    {            
                
                     sum = sum + Arr[i,k];                    

                    }
                   
                  massive[k] = sum/Arr.GetLength(0);
                   sum = 0;
                   
            } 

return massive;
}

    Console.WriteLine("Внесите размерность массива - количество строк");
        int numberRows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Внесите размерность массива - количество столбцов");
                int numberColumns = Convert.ToInt32(Console.ReadLine());

    int[, ] newArr = CreateArray(numberRows,numberColumns,0,9);
            PrintTwoDimensionArray(newArr);
                double[] mas = AverageRows(newArr);

Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца: ");
Console.WriteLine();

PrintArray(mas);
