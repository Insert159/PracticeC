// Показать двумерный массив размером m×n заполненный вещественными числами

// Console.WriteLine("Введите размер массива");
// int m = int.Parse(Console.ReadLine() ?? "0");
// int n = int.Parse(Console.ReadLine() ?? "0");
// double[,] arr = new double[m, n];
// Random r = new Random();

// void printFilledArray(double[,] arr)

// {
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             arr[i, j] = r.Next(-100, 100) + r.NextDouble();
//             Console.Write(arr[i, j] + " ");

//         }
//         Console.WriteLine();
//     }
// }

// printFilledArray(arr);









// Задать двумерный массив следующим правилом: Aₘₙ = m+n

// Console.WriteLine("Введите размер массива");
// int m = int.Parse(Console.ReadLine() ?? "0");
// int n = int.Parse(Console.ReadLine() ?? "0");
// int[,] arr = new int[m, n];

// void fillArray(int[,] arr)

// {
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             arr[i, j] = (i + j)+1;
//         }
//         Console.WriteLine();
//     }
// }


// void printArray(int [,] arr)
// {
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             Console.Write(arr[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }

// fillArray(arr);
// printArray(arr);







// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

// Console.WriteLine("Введите размер массива");
// int m = int.Parse(Console.ReadLine() ?? "0");
// int n = int.Parse(Console.ReadLine() ?? "0");
// int[,] arr = new int[m, n];
// Random r = new Random();

// void fillArray(int[,] arr)

// {
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             arr[i, j] = r.Next(1, 10);
//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void square(int[,] arr)

// {
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             if (i  % 2 == 0 && j%2==0) 
//             {
//                 arr[i, j] = arr[i, j] * arr[i, j];
//             }
//         }
//     }

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// fillArray(arr);
// square(arr);







// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

// Console.WriteLine("Введите размер матрицы:");
//             int N = int.Parse(Console.ReadLine());
//             int M = int.Parse(Console.ReadLine());
//             int[,] matrix = new int[N, M];
//             Random rand = new Random();
//             int[] summ = new int[M];
//             for (int i = 0; i < N; i++)
//             {
//                 for (int j = 0; j < M; j++)
//                 {
//                     matrix[i, j] = rand.Next(0, 10); //рандомные значения для елементов матрицы

//                 }
//             }
//             Console.WriteLine("Матрица");
//             for (int i = 0; i < N; i++)
//             {
//                 for (int j = 0; j < M; j++)
//                 {

//                     Console.Write(matrix[i, j]); //вывод матрицы
//                     summ[i] += matrix[j, i];      //подсчет суммы колонки
//                 } 
//                 Console.WriteLine();
//             }
//             Console.WriteLine();
//             foreach (double elem in summ)
//             {

//                 Console.WriteLine(elem/M); //вывод среднего для колонки
//             }







// Написать программу, которая обменивает элементы первой строки и последней строки

// Console.WriteLine("Введите размер массива");
// int m = int.Parse(Console.ReadLine() ?? "0");
// int n = int.Parse(Console.ReadLine() ?? "0");
// int[,] arr = new int[m, n];
// Random r = new Random();

// void fillArray(int[,] arr)

// {
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             arr[i, j] = r.Next(1, 10);
//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void change(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(1); i++)
//             {
//                 var tmp = arr[arr.GetLength(1) - 1, i];
//                 arr[arr.GetLength(1) - 1, i] = arr[0, i];
//                 arr[0, i] = tmp;
//             }
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }


// fillArray(arr);
// change(arr);









// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.


// Console.WriteLine("Введите размер массива");
// int m = int.Parse(Console.ReadLine() ?? "0");
// int n = int.Parse(Console.ReadLine() ?? "0");
// int[,] arr = new int[m, n];
// Random r = new Random();

// void fillArray(int[,] arr)

// {
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             arr[i, j] = r.Next(1, 10);
//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();


//     var array = arr.Cast<int>().OrderByDescending(a => a).ToArray();

//     int c = 0;
//     for (int j = 0; j < arr.GetLength(0); j++)
//     {
//         for (int k = 0; k < arr.GetLength(1); k++)
//         {
//             arr[j, k] = array[c];
//             Console.Write(arr[j, k] + " ");
//             c++;
//         }
//         Console.WriteLine();
//     }
//     Console.ReadKey();

// }


// fillArray(arr);





// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, 
// что это невозможно (в случае, если матрица не квадратная).

Console.WriteLine("Введите размер массива");
int m = int.Parse(Console.ReadLine() ?? "0");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] arr = new int[m, n];
Random r = new Random();
int rows = arr.GetUpperBound(0) + 1;
int columns = arr.GetUpperBound(1) + 1;

void makeTask(int[,] arr)

{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = r.Next(1, 10);
            Console.Write("{0,4}", arr[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    int[,] array = new int[m, n];
    if (m == n)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[j, i] = arr[i, j];
            }
        }
        Console.WriteLine("Новый массив: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("{0,4}", array[i, j]);
            }
            Console.WriteLine();
        }
    }
    else Console.WriteLine("Невозможно изменить массив");
}

makeTask(arr);


// В прямоугольной матрице найти строку с наименьшей суммой элементов.
/*
Console.WriteLine("Введите размер массива");
int m = int.Parse(Console.ReadLine() ?? "0");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] arr = new int[m, n];
Random r = new Random();

void fillArray(int[,] arr)

{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = r.Next(1, 10);
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void findLess(int[,] arr)
{

    int[] countArr = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            countArr[i] += arr[i, j];
        }
        Console.WriteLine();
    }
    int minNum = 0;
    for (int i = 0; i < countArr.Length; i++)
    {
        if (countArr[i] < minNum) 
        {
        i=minNum;
        }
    }
    Console.Write($"Минимальная сумма на {minNum+1} строке");
}


fillArray(arr);
findLess(arr);
*/