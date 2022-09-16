// Найти точку пересечения двух прямых заданных уравнением 
// y = k1 * x + b1, y = k2 * x + b2, 
//b1 k1 и b2 и k2 заданы

// void Point(int k1, int k2, int b1, int b2)
// {
//     if (k1 == k2) Console.WriteLine("Прямые не пересекутся");
//     else
//     {
//         int y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
//         int x = b1 - b2 / k1 - k2;
//         Console.WriteLine(x);
//         Console.WriteLine(y);
//     }
// }

// Point(2, 2, 4, 5);

// Написать программу масштабирования фигуры Тут для тех кто далеко улетел, 
// чтобы задавались вершины фигуры списком (одной строкой) например: "(0,0) (2,0) (2,2) (0,2)" 
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5 В результате показать координаты, 
// которые получатся. при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

Filling();
Scaling(filedArr);


int[] Filling()
{
    Console.WriteLine("Введите координаты");
    string input = Console.ReadLine();
    string[] strNumbers = input.Split();
    int[] filedArr = new int[strNumbers.Length];
    for (int i = 0; i < filedArr.Length; i++)
        filedArr[i] = int.Parse(strNumbers[i]);
    return filedArr;
}

void Scaling(int[] arr)
{
    Console.WriteLine("Введите коэффициент масштабирования");
    int k = int.Parse(Console.ReadLine());
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * k;
        Console.Write(arr[i] + " ");
    }

}



// Написать программу копирования массива
// int[] arr = new int[] { 2, 3, 45, 6 };
// int[] arrCopy = new int[arr.Length];
// Array.Copy(arr, arrCopy, arr.Length);
// Console.WriteLine(String.Join(", ", arrCopy));

