double vFirstMan = Convert.ToDouble(new Random().Next(100, 200) / 100.0); // m/s
double vSecondMan = Convert.ToDouble(new Random().Next(100, 200) / 100.0);
double vDog = Convert.ToDouble(new Random().Next(800, 2000) / 100.0);
double distance = 100; // m
double minDistance = 3;
int man = 2;
int count = 0;
double time = 0;
while (distance > minDistance)
{
    if (man == 1)
    {
        time = distance / (vDog + vFirstMan);
        man = 2;
        Console.Write($"Собака со скоростью {Math.Round(vDog * 3.6, 2)} км/ч пробегает ");
        Console.WriteLine($"расстояние {Math.Round(distance, 2)} метров за {Math.Round(time, 2)} сек");
    }
    else
    {
        time = distance / (vDog + vSecondMan);
        man = 1;
        Console.Write($"Собака со скоростью {Math.Round(vDog * 3.6, 2)} км/ч пробегает ");
        Console.WriteLine($"расстояние {Math.Round(distance, 2)} метров за {Math.Round(time, 2)} сек");
    }
    distance = (vFirstMan + vSecondMan) * time;
    count++;
}
Console.WriteLine($"Скорость первого человека: {Math.Round(vFirstMan * 3.6, 2)} км/ч");

Console.WriteLine($"Скорость второго человека: {Math.Round(vSecondMan * 3.6, 2)} км/ч");

Console.WriteLine($"Скорость собаки: {Math.Round(vDog * 3.6, 2)} км/ч");

Console.Write($"Собака успевает пробежать {count} раз(а) между первым и вторым человеком,");
Console.WriteLine(" пока они не сблизятся на мин расстояние");