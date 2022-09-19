//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

void SumNumbers(int M, int N)
{

    if (M >= N + 1) return;
    Console.Write($" " + M);
    SumNumbers(M + 1, N);

}
Console.WriteLine("Enter the number M:");
int M = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter a number N bigger than M :");
int N = int.Parse(Console.ReadLine() ?? "0");
if (N < M)
{
    Console.WriteLine("Please enter a number bigger than M");
    return;
}
int result = 0;
for (int i = M; i <= N; i++)
{
    result = result + i;
}
Console.WriteLine($"The list of numbers from {M} to {N} is:");
SumNumbers(M, N);
Console.WriteLine();
Console.WriteLine($"The sum of numbers from {M} to {N} is:" + result);