using System.Collections.Generic;
using System.Linq;

class Swapper
{
    private static int MIN_STRING_LENGTH = 2;
    private static int ITERATOR_STRING_CHOOSIG = 2;

    //Returns true if swapping done
    public static bool StartSwapping(List<string> stringsList)
    {
        for (int i = 0; i < stringsList.Capacity; i++)
        {
            //Check for correct string size
            if (stringsList.ElementAt(i).Count() < MIN_STRING_LENGTH)
                return false;
            if (((i + 1) % ITERATOR_STRING_CHOOSIG) == 0)
            {
               stringsList[i] = DoSWap(stringsList.ElementAt(i));
            }
        }
        return true;
    }

    //Swap first char of the string with last char of same string
    public static string DoSWap(string stringForSwap)
    {
        char[] array = stringForSwap.ToCharArray();
        
        //part of string between first and last chars
        for(int i = 1; i < stringForSwap.Count() -1; i++)
        {
            array[i] = stringForSwap.ElementAt(i);
        }

        array[0] = stringForSwap.Last();
        array[stringForSwap.Count() - 1] = stringForSwap.First();
        string str = new string(array);
        return str;
    }

}
