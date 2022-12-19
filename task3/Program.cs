Console.WriteLine ("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    a[i] = i + 1;
}
for (int i = 0; i < n; i++)
{
    double c = Math.Pow(a[i],3);
     a[i]= Convert.ToInt32 (c);
}
for (int i = 0; i < n; i++)
{
Console.WriteLine (a[i]);
}