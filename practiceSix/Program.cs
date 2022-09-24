//Показать двумерный массив размером m×n заполненный целыми числами

// Console.WriteLine("Введите размер массива");
// int m = int.Parse(Console.ReadLine());
// int n = int.Parse(Console.ReadLine());
// int[,] arr = new int[m, n];
// Random r = new Random();

// void printFilledArray(int [,] arr)
// {
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             arr[i, j] = r.Next(1, 11);
//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// printFilledArray(arr);


//В двумерном массиве n×k заменить четные элементы на противоположные


// Console.WriteLine("Введите размер массива");
// int n = int.Parse(Console.ReadLine() ?? "0");
// int k = int.Parse(Console.ReadLine() ?? "0");
// int[,] arr = new int[n, k];
// Random r = new Random();

// void printFilledArray(int [,] arr)
// {
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < k; j++)
//         {
//             arr[i, j] = r.Next(1, 11);
//             if(arr[i,j]%2==0)
//             {
//                 arr[i,j]=-arr[i,j];
//             }
//             Console.Write(arr[i, j] + " ");

//         }
//         Console.WriteLine();
//     }
// }

// printFilledArray(arr);

// В двумерном массиве показать позиции числа, заданного пользователем или указать, 
// что такого элемента нет

// Console.WriteLine("Введите размер массива");
// int n = int.Parse(Console.ReadLine() ?? "0");
// int k = int.Parse(Console.ReadLine() ?? "0");
// int[,] arr = new int[n, k];
// Random r = new Random();

// void printFilledArray(int[,] arr)
// {
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < k; j++)
//         {
//             arr[i, j] = r.Next(1, 11);
//             Console.Write(arr[i, j] + " ");

//         }
//         Console.WriteLine();
//     }
// }

// void findNumber(int[,] array)
// {
//     Console.WriteLine("Введите искомое число: ");
//     int findNum = int.Parse(Console.ReadLine() ?? "0");
//     int count=0;
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < k; j++)
//         {
//             if (arr[i, j] == findNum)
//             {
//                 Console.Write($"Строка вашего числа ={i + 1}, столбец = {j + 1} ");
//                 count++;
//             }
//         }
//     }
//     if (count ==0) Console.WriteLine("No");
// }



// printFilledArray(arr);
// findNumber(arr);



// В матрице чисел найти сумму элементов главной диагонали

Console.WriteLine("Введите размер массива");
int n = int.Parse(Console.ReadLine() ?? "0");
int k = int.Parse(Console.ReadLine() ?? "0");
int[,] arr = new int[n, k];
Random r = new Random();

void printFilledArray(int[,] arr)

{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < k; j++)
        {
            arr[i, j] = r.Next(1, 11);
            Console.Write(arr[i, j] + " ");

        }
        Console.WriteLine();
    }
}

void summDiag(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < n; i++) 
    {
        for (int j = 0; j < k; j++)
        {
            if (i == j || )
            {
                sum=sum+arr[i,j];
            }

        }
        Console.WriteLine();
    }
    Console.WriteLine(sum);
}

printFilledArray(arr);
summDiag(arr);
