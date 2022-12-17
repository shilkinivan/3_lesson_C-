Console.WriteLine ("Введите число ");
int n = int.Parse(Console.ReadLine());
int[] a = new int[n];
for (int i = 1; i <= a.Length; i++)
{
    double cube = i * i * i;
    Console.WriteLine (cube);
}