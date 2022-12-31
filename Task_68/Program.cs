/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
Console.WriteLine("Введите число M: ");
int M = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "");

// функция Аккермана:
int FunctionA (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return FunctionA(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return FunctionA(numberM - 1, FunctionA(numberM, numberN - 1));
return FunctionA(numberM, numberN);
}

Console.WriteLine($"Функция Аккермана для чисел A({M},{N}) = {FunctionA(M, N)}");