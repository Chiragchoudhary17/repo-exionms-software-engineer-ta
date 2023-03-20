using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        a[] arry =  {1,2,1,2,5,4,8,6,54,7,9,5,44,21,5,,4,5,5,4,4}
        int EmptyArr = -1;
        for(in i = 0 ; i<arry.Length; i++)
        {
            if(arry[i] == null || arry[i] == null)
            {
                EmptyArr = i
            }
        }
        Console.Writeline("Empty array Index is " +EmptyArr);
    }
}