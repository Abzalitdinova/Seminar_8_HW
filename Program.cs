// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int rows = 8;
// int columns = 6;
// int [,] matrix = new int [rows,columns];

// int minSumRow = int.MaxValue;
// int minSumIndex = 0;
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     int sumRow = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix [i,j] = new Random().Next(11); 
//         Console.Write(matrix[i,j] + " ");
//             sumRow += matrix [i,j];
//     }
//         Console.WriteLine ($"сумма: {sumRow}");
//         if (sumRow < minSumRow )
//             {
//                 minSumRow = sumRow; 
//                 minSumIndex = i;
//             }
// }
// Console.WriteLine($"индекс строки с минимальной  суммой {minSumIndex}");


// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

// int rows = 2;
// int columns = 3;
// int [,] matrix = new int [rows,columns];
// int [,] matrix1 = new int [rows,columns];
// int [,] result = new int [rows,columns];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix [i,j] = new Random().Next(11); 
//         matrix1 [i,j] = new Random().Next(11);
//         result [i,j] = matrix[i,j] * matrix1[i,j];
//         Console.Write(result[i,j] + " ");
//     }
//     Console.WriteLine();
// }

// cформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

// int [,,] nums3 = new int[,,] {{{4,18},{7,9}}, {{12,6},{21,3}},{{14,8},{15,2}}};
// for (int i = 0; i < nums3.GetLength(0); i++)
// {
//     for (int j = 0; j < nums3.GetLength(1); j++)
//     {
//         for (int k = 0; k < nums3.GetLength(2); k++)
//         {
//             Console.Write($"{nums3[i,j,k]} ({i}, {j}, {k})");
//             Console.Write(" ");
//         }
//     Console.WriteLine();
//     }
//     Console.WriteLine();
// }

