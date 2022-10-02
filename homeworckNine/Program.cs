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








// Написать программу вычисления функции Аккермана
int Ack(int m, int n)
{
    if (m > 6 || n > 6 || m < 0 || n < 0) return -1;

    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ack(m - 1, 1);
    }
    else
    {
        return Ack(m - 1, Ack(m, n - 1));
    }
}
Console.WriteLine(Ack(2, 3));


