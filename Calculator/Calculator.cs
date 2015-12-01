using System.Collections.Generic;
using System.Linq;

class Claculator
{
    //Add all numbers to each other from parametes list
    //and returns the result
    public static double Add(List<double> parameters)
    {
        double result = 0;
        foreach (double number in parameters)
        {
            result += number;
        }
        return result;
    }

    //Substarct numbers from parametes list
    //and returns the result
    public static double Substract(List<double> parameters)
    {
        double result = 0;
        foreach (double number in parameters)
        {
            result -= number;
        }
        return result;
    }

    //Multiply all numbers to each other from parametes list
    //and returns the result
    public static double Multiply(List<double> parameters)
    {
        double result = 1;
        foreach (double number in parameters)
        {
            result *= number;
        }
        return result;
    }

    //Devide all numbers to each other from parametes list
    //and returns the result
    public static double Devide(List<double> parameters)
    {
        double result = parameters.ElementAt(0);
        for (int i = 1; i < parameters.Count; i++)
        {
            result /= parameters.ElementAt(i);
        }
        return result;
    }
}
