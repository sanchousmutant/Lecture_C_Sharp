// Цикл for

string Method4(int count, string text)
{
    string result = string.Empty;

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(3, "What is your name? ");
System.Console.WriteLine(res);


// Цикл в цикле

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        System.Console.Write($"{i} X {j} = {i * j} |");
        
    }
    System.Console.WriteLine();
    System.Console.WriteLine();
}