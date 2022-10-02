// Показать натуральные числа от M до N, N и M заданы


//  void ShowNum (int m, int n)
//  {
//     if (n<m) return;
//     ShowNum(m, n-1); 
//     Console.Write(n+" ");
    
//  }

// ShowNum(1,4);



// Найти сумму элементов от M до N, N и M заданы

// int Sum(int m, int n)
// {
//     if (n == m) return n;
//     return m + Sum(m + 1, n);
// }
// Console.WriteLine(Sum(1, 10));




// Найти сумму цифр числа

// int SumDigits(int number)
// {
//     if (number < 1) return 0;
//     int result = 0;
//     return SumDigits(number / 10) + number % 10;
// }

// Console.WriteLine($"Sum digits: {SumDigits(66)}");





// Написать программу вычисления функции Аккермана
// int Ack(int m, int n)
// {
//     if (m > 6 || n > 6 || m < 0 || n < 0) return -1;

//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0)
//     {
//         return Ack(m - 1, 1);
//     }
//     else
//     {
//         return Ack(m - 1, Ack(m, n - 1));
//     }
// }
// Console.WriteLine(Ack(2, 3));



// Написать программу возведения числа А в целую стень B
// int DegreeOfNumber(int numberA, int numberB)
// {
//     if (numberB < 1) return 1;
//     return numberA * (DegreeOfNumber(numberA, numberB - 1));
// }

// Console.Write("Input number A: ");
// int numberA = int.Parse(Console.ReadLine());
// Console.Write("Input number B: ");
// int numberB = int.Parse(Console.ReadLine());

// Console.WriteLine($"Degree of {numberA} in {numberB}: {DegreeOfNumber(numberA, numberB)}");



// Написать программу показывающие первые N чисел, для которых каждое 
// следующее равно сумме двух предыдущих. Первые два элемента 
// последовательности задаются пользователем

int N = 10;
int a = 3;
int b = 5;
int Metod(int x, int y, int num)
{
    if (num == 1) return x;
    if (num == 2) return y;
    return Metod(x, y, num - 1) + Metod(x, y, num - 2);
}
for (int i = 1; i < N; i++)
{
    Console.Write(Metod(a, b, i) + " ");
}