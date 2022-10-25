Array();
void Array()
{
    int[] N = new int[8];
    Console.Write("Array [ ");
    for (int i = 0; i < N.Length; i++)
    {
        N[i] = new Random().Next(0, 99);
        Console.Write($"{N[i]} ");
    }
    Console.Write("]");
}