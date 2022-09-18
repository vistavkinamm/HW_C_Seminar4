// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А: ");
int numA=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число В: ");
int numB=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число А возведеноое в степень В: " +GetExpon(numA));

int GetExpon(int number)
{
    int expon=numA;
    int count=1;
    while(numB>count)
    {
        count++;
        expon=expon*numA;
    }
    return expon;
}
