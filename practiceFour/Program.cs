// Написать программу замену элементов массива на противоположные

// Console.WriteLine("Заполните массив из 5 элементов");
// int [] arr = new int [5];
// for (int i = 0; i <arr.Length; i++)
//     {
//     arr[i]=int.Parse(Console.ReadLine());   
//     }
// for (int i= 0; i <arr.Length ; i++)
//     {
//     arr[i]=arr[i]*(-1);
//     Console.Write(arr[i]+" ");
//     } 

// Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел

Console.WriteLine("Какой длинны массив?");
int size = int.Parse(Console.ReadLine());
int[] arr = new int[size];
int ch = 0;
int nch = 0;
for (int i = 0; i < size; i++)
{
    arr[i] = new Random().Next(100, 1000);
    Console.Write(arr[i]+" ");
}

for (int i = 0; i < size; i++)
{
    if (arr[i] % 2 == 0)
    {
        ch++;
    }
}
nch = size - ch;
Console.WriteLine();
Console.WriteLine(ch);
Console.WriteLine(nch);


// Найти сумму чисел одномерного массива стоящих на нечетной позиции

// Console.WriteLine("Какой длинны массив?");
// int size= int.Parse(Console.ReadLine());
// int [] arr = new int [size];

// int [] FillArray () {
// for (int i = 0; i <size; i++)
//     {
//     arr[i]=new Random().Next(1,100);   
//     Console.Write(arr[i]+" ");
//     }
//     Console.WriteLine();
//     return arr;
// }    

// void ControlArr (int [] arr)
// {
//     int sum=0;
//     for (int i = 0; i <arr.Length; i++)
//     {
//         if (i%2==1)
//         {
//             sum=sum+arr[i];
//         }
//     }
//     Console.WriteLine(sum);
// }

// FillArray();
// ControlArr(arr);
