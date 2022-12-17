Console.WriteLine ("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    a[i] = new Random().Next(1,n);
}
for (int i = 1; i <= n; i++)
{
    int cube = i * i * i;
    Console.WriteLine (cube);
}