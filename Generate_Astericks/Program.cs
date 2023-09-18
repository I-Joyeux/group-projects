

//while (answer=='y' ||answer=='Y')
//{

//while ()
//{ 

//}
// Console.Write("Do oyu want to generate another set of astericks? Y or N");
//   char answer=Convert.ToChar(Console.ReadLine());
//}
char astreriks = Convert.ToChar('*');
Console.Write("Enter the number of astericks  ");
int amount = Convert.ToInt32(Console.ReadLine());

while (true)
{
    Console.Write("Do you want to generate another set of astericks? Y or N  ");
    char answer = Convert.ToChar(Console.ReadLine());

    while (answer == 'y' || answer == 'Y')
    {

        for (int i = 0; i <= amount; i++)
        {

            Console.Write(astreriks);

        }
        Console.WriteLine("Do oyu want to generate another set of astericks? Y or N");
        answer = Convert.ToChar(Console.ReadLine());
        amount = Convert.ToInt32(Console.ReadLine());
        astreriks = Convert.ToChar('*');
    }
    Console.WriteLine("bye");
}

