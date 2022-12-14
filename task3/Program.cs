void Cube (int[] array, int s)
{
    for (int i = 0; i < s; i++)
    {
        double cube = Math.Pow(array[i],3);
        Console.WriteLine (cube);
    }
}
Console.WriteLine ("Введите число ");
int n = int.Parse(Console.ReadLine());
int[] a = new int[n];
for (int i = 0; i < a.Length; i++)
{
    a[i] = i + 1;
}
Cube (a,n);