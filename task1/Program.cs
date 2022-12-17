Console.WriteLine("Введите число пятизначное число: ");
string n = Console.ReadLine();
int l = n.Length;
if (l==5)
{
     if (n[0]==n[4])
     {
          if(n[1]==n[3])
          {
            Console.WriteLine("Палиндром");   
          }
          else
            Console.WriteLine("Не палиндром");
     }
     else
     Console.WriteLine("Не палиндром");
}
else
Console.WriteLine("Введите корректное число");