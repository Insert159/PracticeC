


// Найти произведение двух матриц

// Console.WriteLine("Введите размер первого массива");
// int m = int.Parse(Console.ReadLine() ?? "0");
// int n = int.Parse(Console.ReadLine() ?? "0");
// int[,] arr = new int[m, n];
// Console.WriteLine("Введите размер второго массива");
// int m2 = int.Parse(Console.ReadLine() ?? "0");
// int n2 = int.Parse(Console.ReadLine() ?? "0");
// int[,] arr2 = new int[m, n];
// Random r = new Random();

// void fillArray(int[,] arr, int[,] arr2)
// {
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             arr[i, j] = r.Next(1, 10);
//             Console.Write("{0,4}", arr[i, j]);
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();

//     for (int i = 0; i < m2; i++)
//     {
//         for (int j = 0; j < n2; j++)
//         {
//             arr2[i, j] = r.Next(1, 10);
//             Console.Write("{0,4}", arr2[i, j]);
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();

//     if (m != m2)
//         Console.WriteLine("Чёт не так, давай по другому");
//     double[,] result = new double[m, n2];
//     for (int i = 0; i < m; ++i) // каждая строка A
//     {
//         for (int j = 0; j < n2; ++j) // каждый столбец B
//         {
//             for (int k = 0; k < n; ++k)
//             {
//                 result[i,j] += arr[i,k] * arr2[k,j];
//             }
//         }
//     }
//     foreach (var i in result)
//     {
//         Console.Write($"{i} ");
//     }
// }

// fillArray(arr, arr2);







// В двумерном массиве целых чисел. Удалить строку и столбец,
// на пересечении которых расположен наименьший элемент.

// Console.WriteLine("Введите размер массива");
// int m = int.Parse(Console.ReadLine() ?? "0");
// int n = int.Parse(Console.ReadLine() ?? "0");
// int[,] arr = new int[m, n];
// int x = 0;
// int y = 0;
// Random r = new Random();

// void newTask(int[,] arr)
// {
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             arr[i, j] = r.Next(1, 10);
//             Console.Write("{0,4}", arr[i, j]);
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();

//     int min = int.MaxValue;

//     for (int i = 0; i < m; ++i)
//     {
//         for (int j = 0; j < n; ++j)
//         {
//             if (arr[i, j] < min)
//             {
//                 min = arr[i, j];
//                 x = i;
//                 y = j;
//             }
//         }
//     }
//     Console.WriteLine($"Минимальный элемент = {min}");

//     for (int i = 0; i < m; ++i)
//     {
//         for (int j = 0; j < n; ++j)
//         {
//             if ((i == x) || (j == y))
//                 continue;
//             else
//                 Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// newTask(arr);





// Сформировать трехмерный массив не повторяющимися двузначными
// числами показать его построчно на экран выводя индексы
// соответствующего элемента

// Console.WriteLine("Какого размера будет массив?");
// int m = int.Parse(Console.ReadLine() ?? "0");
// int n = int.Parse(Console.ReadLine() ?? "0");
// int o = int.Parse(Console.ReadLine() ?? "0");
// int[,,] arr = new int[m, n, o];
// Random r = new Random();

// void threeDArray(int[,,] arr)
// {
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             for (int k = 0; k < o; k++)
//             {
//                 var n = r.Next(10, 99);
//                 if (!arr.Contains(n))
//                 {
//                     arr.Add(n);
//                     Console.Write($"Индексы {i} {j} {k}= {arr[i, j, k]} ");
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }

// threeDArray(arr);




//Показать треугольник Паскаля 
//*Сделать вывод в виде равнобедренного треугольника

int row =9;
int[,] triangle =new int [row, row];
const int cellWidth =4;

void FillTriangle()
{
    for (int i = 0; i < row; i++)
    {
        triangle [i,0]=1;
        triangle[i,i]=1;
    }

    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            triangle[i,j]=triangle[i-1, j-1]+triangle[i-1, j];
        }
    }
}

/*void Print ()
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            if(triangle[i,j]!=0)
                Console.Write ($"{triangle[i,j],cellWidth}");
        }
        Console.WriteLine();
    }
}
*/
void Magic()
{
    int col =cellWidth * row;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col, i+1);
            if(triangle[i,j]!=0) Console.Write($"{triangle[i,j], cellWidth}");
            col+=cellWidth*2;
        }
        col =cellWidth*row-cellWidth*(i+1);
        Console.WriteLine();
    }
}

FillTriangle();
//Print();
Magic();