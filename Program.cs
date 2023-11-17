// // Задача 46:Задайте двумерный массив размером m×n, 
// // заполненный случайными целыми числами. 
// //m = 3, n = 4.

// Console.Write("Введите количество строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов:");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows,columns];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(-10,10);
//         if(array[i,j] <0) Console.Write(" "+array[i,j]); // Что бы отрицательные 
// // и полож числа распологались ровно в таблице
//         else Console.Write("  "+array[i,j]);
//     }
//    Console.WriteLine(); 
// }

// //for (int i = 0; i < array.GetLength(0); i++)
// //{
//     //for (int j = 0; j < array.GetLength(1); j++)
//    // {
//    //     Console.Write(array[i,j]+" ");
//    // }
//    // Console.WriteLine();
// //}

// // Задача 48: Задайте двумерный массив размера m на n, 
// // каждый элемент в массиве находится по формуле: Aₘₙ= m+n. 
// // Выведите полученный массив на экран.
// // 0 1 2 3
// // 1 2 3 4
// // 2 3 4 5

// Console.Write("Введите количество строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов:");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows,columns];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = i+j;
//         Console.Write(" "+array[i,j]);
//     }
//    Console.WriteLine(); 
// }


// //Задача 49: Задайте двумерный массив. 
// //Найдите элементы, у которых оба индекса чётные, 
// //и замените эти элементы на их квадраты.

// //Например, изначально массив выглядел вот так: 
// //1 4 7 2 
// //5 9 2 3 
// //8 4 2 4
// //Новый массив будет выглядеть вот так: 
// //1 4  7 2 
// //5 81 2 9 
// //8 4  2 4

// Console.Write("Введите количество строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов:");
// int columns = Convert.ToInt32(Console.ReadLine());

// double[,] array = new double[rows, columns];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(0, 10);
//     }
// }
// PrintArray(array);

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//           if (i % 2 == 0 && j % 2 == 0) array[i, j] = Math.Pow(array[i, j], 2);
//     }
// }
// Console.WriteLine();
// PrintArray(array);

// void PrintArray(double[,] matrix)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }


// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д. 
// Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// Сумма элементов главной диагонали: 1+9+2 = 12




Console.Write("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];

void RandomArray(int[,] matrix)
{
        for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int SumDiagonal(int[,] matrix)
{
    int result = 0;
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i == j) result = result + matrix[i, j];
            }
            Console.WriteLine();
        }
    }
    return result;
}

RandomArray(array);
PrintArray(array);
Console.WriteLine(SumDiagonal(array));