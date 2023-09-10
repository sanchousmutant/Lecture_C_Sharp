// Факториал числа с помощью рекурсии
int Factorial(int n)
{
    if (n == 1) return 1; // 1! == 1
    else return n * Factorial(n - 1);
}

for (int i = 1; i < 25; i++)
{
    System.Console.WriteLine($"{i}! = {Factorial(i)}");
}