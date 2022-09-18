int [] numbers = new int[8];
Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, 11);
    Console.Write(" " + MethodArray (i) + " ");
 }
Console.Write("]");

int MethodArray (int a)
{
    return numbers[a];
}