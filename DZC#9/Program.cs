// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// int n = 0;
// Console.Write("Введите натуральное число: ");
// bool boolN = int.TryParse(Console.ReadLine(), out int numberN);
// //Проверяем на число
// if (!boolN)
// {
//     Console.WriteLine("Введено неверное значение!");
//     return;
// }
// else
// {
//     n = numberN;
// }
// //Рекурсия 
// void printAllNaturalNumbers(int m)
// {
//     if (m == 1)
//     {
//         Console.Write(1);
//         return;
//     }
//     else
//     {
//         Console.Write(m + ", ");
//         printAllNaturalNumbers(m - 1);
//     }
// }
// printAllNaturalNumbers(n);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите начальное число M:");
// int numberM = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите начальное число M:");
// int numberN = int.Parse(Console.ReadLine());
// ///Метод нахождения суммы натуральных элементов в промежутке от M до N
// void GapNumberSum (int numberM, int numberN, int sum)
// {
//     if (numberM > numberN) 
//     {
//         Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
//         return;
//     }
//     sum = sum + (numberM++);
//     GapNumberSum(numberM, numberN, sum);
// }
// GapNumberSum(numberM, numberN, 0);

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int n = 0;
int m = 0;
Console.Write("Введите первое значение: ");
bool boolN = int.TryParse(Console.ReadLine(), out int numberN);
Console.Write("Введите второе значение: ");
bool boolM = int.TryParse(Console.ReadLine(), out int numberM);
//Check 
if (!boolN || !boolM)
    Console.WriteLine("Не верно введены значения! Введите число!");
else
{
    n = numberN;
    m = numberM;
}
// функция Аккермана
int ackermanFunction(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return ackermanFunction(n - 1, 1);
    else
        return ackermanFunction(n - 1, ackermanFunction(n, m - 1));
}
int result = ackermanFunction(n, m);
Console.WriteLine($"A({n},{m}) = {result}");