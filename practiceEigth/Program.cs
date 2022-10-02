// Показать натуральные числа от N до 1, N задано
 
//  int N =int.Parse(Console.ReadLine()?? "0");

//  void ShowNum (int n)
//  {
//     if (n<1) return;
//     Console.Write(n+" ");
//     ShowNum(n-1);
    
//  }

// ShowNum(N);

// Показать натуральные числа от 1 до N, N задано

 void ShowNum (int n)
 {
    if (n<1) return;
    ShowNum (n-1);
    Console.Write(n+" ");
    
 }

ShowNum(5);