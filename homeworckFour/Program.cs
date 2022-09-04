// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

// void array()
// {
//     int[] arr = new int[123];
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(1, 101);
//         Console.Write($" {arr[i]} ");
//         if (arr[i] < 100 && arr[i] > 9)
//         {
//             count++;
//         }
//     }
//     Console.WriteLine();
//     Console.WriteLine(count);
// }

// array();



// Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.

// void secondTaskWithArray()
// {
//     int[] arr = new int[8];
//     int mult = 1;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(1, 11);     
//         Console.Write($" {arr[i]} ");
//     }
//     Console.WriteLine();
//     int size=arr.Length;

//     for (int i = 0; i < arr.Length/2; i++)
//     {
//         mult=arr[i]*arr[size-1-i];
//         Console.Write($" {mult} ");
//     }
// }



// secondTaskWithArray();



// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом


void thirdTaskWithArray()
{
    int max = 0;
    int min = int.MaxValue;
    int[] arr = new int[8];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 11);
        Console.Write($" {arr[i]} ");
        if (arr[i] > max)
        {
            max=arr[i];
        }
        if (arr[i] < min)
        {
            min=arr[i];
        }
    }
    Console.WriteLine();
    int diff = max - min;
    Console.Write($" {max} {min} {diff} ");
}



thirdTaskWithArray();