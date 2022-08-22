void divide (int num)
{
    if (num%7==0 && num%23==0){
        Console.WriteLine("Число кратно 7 и 23");
    }
    else {
        Console.WriteLine("Число не кратно 7 и 23");
    }

}


divide(23);


// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

void plane(int x, int y)
{
    if(x>0 && y>0){
        Console.WriteLine("Плоскость 1");
    }
    if(x<0 && y>0){
        Console.WriteLine("Плоскость 2");
    }
    if(x<0 && y<0){
        Console.WriteLine("Плоскость 3");
    }
    else{
        Console.WriteLine("Плоскость 4");
    }
}

plane(4,-5);

// Программа проверяет пятизначное число на палиндромом.

void palindrome (int x)
{
    if(x / 1000 == (x % 10) * 10 + (x % 100) / 10){
        Console.WriteLine("Число палиндром");
    }
    else{
        Console.WriteLine("Число не палиндром");
    }
}

palindrome(12321);
