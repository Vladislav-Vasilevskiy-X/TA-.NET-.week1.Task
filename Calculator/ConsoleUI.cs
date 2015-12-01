using System;
using System.Collections.Generic;

class ConsoleUI
{
    static void Main(string[] args)
    {
        //Main loop
        ConsoleUI.doLoop();
    }

    //Loop for console UI
    public static void doLoop()
    {
        List<double> list = new List<double>();
        string line;    //line will be readed from the console
        double number = 0;      //number will be readed from the console
        int operationNumber = 0;    //operation's id

        //loop for input numbers
        while (true)
        {
            Console.WriteLine("Type the number (type 's' to stop typing).");
            line = Console.ReadLine();

            if (double.TryParse(line, out number))
            {
                list.Add(number);
            }
            else
            {
                if (line.Equals("s")) break;
                else Console.WriteLine("Try again.");
            }

        }

        //loop for operation choosing
        while (true)
        {
            ConsoleUI.printOperations();
            Console.WriteLine("Type the number of operation.");
            line = Console.ReadLine();

            if (int.TryParse(line, out operationNumber))
            {
                double a = doOperation(operationNumber, list);
                Console.WriteLine("Result: " + a);
                break;
            }
            else Console.WriteLine("Try again.");
        }
    }

    //Returns result of choosen operation and pasted numbers
    public static double doOperation(int operationNumber, List<double> array)
    {
        switch(operationNumber)
        {
            case 1:
                {
                    return Claculator.Add(array);
                }
            case 2:
                {
                    return Claculator.Substract(array);
                }
            case 3:
                {
                    return Claculator.Multiply(array);
                }
            case 4:
                {
                    return Claculator.Devide(array);
                }
            default: return 0;
        }
    }

    //Prints the list of operations on the screen
    public static void printOperations()
    {
        Console.WriteLine("1 - Addition.");
        Console.WriteLine("2 - Substraction.");
        Console.WriteLine("3 - Multiplication.");
        Console.WriteLine("4 - Devision.");
    }
}
