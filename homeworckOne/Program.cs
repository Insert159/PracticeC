// По двум заданным числам проверять является ли первое квадратом второго

// Console.WriteLine("Введите первое число");
// double numberOne = Double.Parse(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// double numberTwo = Double.Parse(Console.ReadLine());
// if(numberOne==numberTwo*numberTwo){
//     Console.WriteLine("Первое число- это квадрат второго");
// }
// else{
//     Console.WriteLine("Никто, ничей не квадрат");
// }

// По заданному номеру дня недели вывести его название

// Console.WriteLine("Введите число дня недели");
// double numberOne = Double.Parse(Console.ReadLine());
// if(numberOne==1){
//     Console.WriteLine("Понедельник");
// }
// else if(numberOne==2){
//     Console.WriteLine("Вторник");
// }
// else if(numberOne==3){
//     Console.WriteLine("Среда");
// }
// else if(numberOne==4){
//     Console.WriteLine("Четверг");
// }
// else if(numberOne==5){
//     Console.WriteLine("Пятница");
// }
// else if(numberOne==6){
//     Console.WriteLine("Суббота");
// }
// else if(numberOne==7){
//     Console.WriteLine("Воскресерье");
// }
// else{
//     Console.WriteLine("Нет такого дня недели");
// }


// Найти максимальное из трех чисел   

// Console.WriteLine("Введите первое число");
// double numberOne = Double.Parse(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// double numberTwo = Double.Parse(Console.ReadLine());
// Console.WriteLine("Введите третье число");
// double numberThree = Double.Parse(Console.ReadLine());
// if(numberOne>numberTwo && numberOne>numberThree){
//     Console.WriteLine("Число "+numberOne+" самое большое");
// }
// else if(numberOne<numberTwo && numberTwo>numberThree){
//     Console.WriteLine("Число "+numberTwo+" самое большое");
// }
// else {
//     Console.WriteLine("Число "+numberThree+" самое большое");
// }


// Выяснить является ли число чётным

// Console.WriteLine("Введите число");
// double numberOne = Double.Parse(Console.ReadLine());
// if(numberOne%2==0){
//     Console.WriteLine("Число чётное");
// }
// else {
//     Console.WriteLine("Число нечётное");
// }


// Показать четные числа от 1 до N

// Console.WriteLine("Введите число");
// int number = int.Parse(Console.ReadLine());
// for (int i = 0; i <=number ; i++)
// {
//     if(i%2==0){
//             Console.Write(i+" ");
//         }
// }



// Показать вторую цифру трёхзначного числа

// Console.WriteLine("Введите число");
// int number = int.Parse(Console.ReadLine());
// int dec=number%100;
// int divide=dec/10;
// Console.Write("Вторая цифра трехзначного номера = "+divide);



// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

// int number = new Random().Next(10, 100);
// int dec=number%10;
// int numberTwo=number/10;
// int divide=0;
// if(dec>numberTwo){
//     divide=dec;
// }
// else{
//     divide=numberTwo;
// }
// Console.Write("Большая цифра числа "+number+" "+divide);



// Удалить вторую цифру трёхзначного числа

// Console.WriteLine("Введите число");
// int number = int.Parse(Console.ReadLine());
// int delete = 2;
// var str = number.ToString();
// number = int.Parse(str.Remove(str.Length - delete, 1));
// Console.Write(number);


// Выяснить, кратно ли число заданному, если нет, вывести остаток.

// Console.WriteLine("Введите число");
// int numberOne = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int numberTwo = int.Parse(Console.ReadLine());
// if(numberOne%numberTwo==0){
// Console.Write("Чисто "+numberOne+" кратно "+numberTwo);
// }
// else{
//     Console.Write("Чисто "+numberOne+" не кратно "+numberTwo);
// }


// Найти третью цифру числа или сообщить, что её нет

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int digitIndex = 2; 
int digit = number.ToString()[digitIndex] - '0';
Console.Write("Третья цифра трехзначного номера = "+digit);



