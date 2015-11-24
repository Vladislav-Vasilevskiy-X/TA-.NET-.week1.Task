using System.Collections.Generic;
using System.Linq;

class Swapper
{
    public static bool StartSwapping(List<string> stringsList)
    {
        for (int i = 0; i < stringsList.Capacity; i++)
        {
            if (stringsList.ElementAt(i).Count() < 2)
                return false;
            if (((i + 1) % 2) == 0)
            {
               stringsList[i] = DoSWap(stringsList.ElementAt(i));
            }
        }
        return true;
    }

    public static string DoSWap(string stringForSwap)
    {
        char[] array = stringForSwap.ToCharArray();
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
