// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arry = {25,54,78,7,86,95,74};
       int i = 0;
       int j = arry.Length-1;
       var pivot = arry[i];
       
       while(i<=j)
       {
        while(array[i]<pivot)
        {
         i++;   
        }
        while(array[j]>pivot)
        {
            j--;
        }
        if(i<=j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            i++;
            j--;
        }
        }
       }
    }
}