/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.WriteLine("Введите число M: ");
int M = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "");
int SumFor(int M, int N)
{
    int result = 0;
    for (int i = M; i <= N; i++) result += i;
    return result;
}
string SumRec(int M, int N)
{
    if (M <= N) return $"{M}" + SumRec(M + 1, N);
    else return String.Empty;
}
//Console.WriteLine(SumRec(M, N));
Console.WriteLine(SumFor(M, N));





