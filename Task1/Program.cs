//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

//M = 1; N = 5. -> ""1, 2, 3, 4, 5""

//M = 4; N = 8. -> ""4, 6, 7, 8""
void PrintNumbers(int M, int N)
{

    if (M >= N + 1) return;
    Console.Write(M + " ");
    PrintNumbers(M + 1, N);

}

Console.WriteLine("Enter the number M: ");
int M = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter the number N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"The list of numbers from {M} to {N} is : ");
PrintNumbers(M, N);