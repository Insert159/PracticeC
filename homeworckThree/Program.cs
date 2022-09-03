// Найти кубы чисел от 1 до N

// void cube (int n)
// {
//     for (int i = 1; i <= n; i++)
//     {
//         int cube=i*i*i;
//         Console.WriteLine($" {cube} ");
//     }
// }

// cube (5);



// Возведите число А в натуральную степень B используя цикл

// void degree (int a, int b)
// {
//     int deg=1;
//     for (int i = 1; i <= b; i++)
//     {
//         deg=deg*a;
//     }
//     Console.WriteLine(deg);
// }

// degree(2,5);



// Подсчитать сумму цифр в числе

// void sum ()
// {   
//     Console.WriteLine("Введите число:");
//     int number = int.Parse(Console.ReadLine());
//     int summ=0;   
//     while(number>0)
//     {
//         summ = summ + number % 10;
//         number = number /10 ;    
//     }

//     Console.WriteLine(summ);
// }

// sum();



// Написать программу вычисления произведения чисел от 1 до N

// void multiply()
// {
//     Console.WriteLine("Введите число:");
//     int number = int.Parse(Console.ReadLine());
//     int mult=1;
//     for (int i = 1; i <= number; i++)
//     {
//         mult=mult*i;
//     }
//     Console.WriteLine(mult);

// }

// multiply();



// Показать кубы чисел, заканчивающихся на четную цифру

// void showCube()
// {
//     Console.WriteLine("Введите число:");
//     int number = int.Parse(Console.ReadLine());
//     int cube = 1;
//     for (int i = 1; i <= number; i++)
//     {
//         if(i%2==0){
//         cube=i*i*i;
//         Console.WriteLine($" {cube} ");
//         }
//     }
// }
// showCube();



// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

// int[] element = new int[8];
// for (int i = 0; i < element.Length; i++)
// {
//     element[i]=new Random().Next(0,2);
//     Console.Write($" {element[i]} ");
// }


// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int[] element = new int[12];
int sum=0;
for (int i = 0; i < element.Length; i++)
{
    element[i]=new Random().Next(0,10);
    Console.Write($" {element[i]} ");
    if(element[i]>0)
    {
        sum=sum+element[i];
    }
    Console.WriteLine();
}
Console.WriteLine(sum);