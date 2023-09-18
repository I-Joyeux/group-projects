// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int total = 0;
int sum = 0;
for (int i = 0; i < 5; i++)
{
    Console.Write("Enter a number >> ");
    int num=Convert.ToInt32(Console.ReadLine());

    sum =total += num;
  

  ;
}
Console.WriteLine(sum);