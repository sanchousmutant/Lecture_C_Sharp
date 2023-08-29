// Первая группа методов — не принимает никаких аргументов и ничего не возвращают (void - метод)

void Method1()
{
    System.Console.WriteLine("Author Sancho");
} 

Method1();

// Вторая группа методов — принимает какие-то аргументы, но ничего не возвращают (void - метод)

void Method2(string msg)
{
    System.Console.WriteLine(msg);
}
 Method2("Привет");


 void Method2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}
 Method2_1(msg: "How are you", count: 4); //  тоже самое что Method2_1("How are you", 4)

 // при именованном обращении к аргументу функции порядок может быть
 // в произвольнольном виде Method2_1(count: 4, msg: "How are you")


// Третья группа методов — может что-то возвращать, но не принимает никаких

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
System.Console.WriteLine(year);

// Четвёртая группа методов — что-то принимает (аргументы, данные). 
// И что-то возвращает для дальнейшей работы.

string Method4(int count, string c)
{
    int i = 0;
    string result = string.Empty;
    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}
string res = Method4(3, "What is your name?");
System.Console.WriteLine(res);