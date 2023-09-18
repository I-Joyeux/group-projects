//Sum ints:
using static System.Console;

class sumInts
{
    static void Main()
    {
        int uInput = 0, oTotal = 0;
        string uInputString;

        Write("Enter an integer to add or enter 999 to get the total: ");
        uInputString = Console.ReadLine();
        uInput = Convert.ToInt32(uInputString);

        while (uInput != 999)
        {
            oTotal += uInput;
            Write("Enter an integer to add or enter 999 to get the total: ");
            uInputString = Console.ReadLine();
            uInput = Convert.ToInt32(uInputString);
        }
        WriteLine();
        WriteLine("The sum is {0}", oTotal.ToString());

    }
}


//Repeat string:

class RepeatStings
{
    static void Main()
    {
        string iText, loopCountString;
        int loopCount = 0;

        Write("Enter the string to repeat: ");
        iText = Console.ReadLine();
        WriteLine();
        Write("Enter how many times to repeat the string: ");
        loopCountString = Console.ReadLine();
        loopCount = Convert.ToInt32(loopCountString);

        for (int i = 0; i <= loopCount; i++)
        {
            WriteLine(iText);
        }
    }
}
