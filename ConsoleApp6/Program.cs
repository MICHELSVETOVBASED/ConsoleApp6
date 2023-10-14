using System;
using System.ComponentModel.DataAnnotations;

public class MainClass
{
    public static void Main()
    {
        string num1 = Console.ReadLine();
        int Length = num1.Length;



        string [] sum = new string[; 
        for ( int i = 0; i<num1.Length; i++ )
        {
            for ( int j = i+1; j < num1.Length; j++ )
            {
                if (num1[i] == num1[j])
                {
                    continue;
                }
                else if (num1[i].Equals(sum))
                {
                    continue;
                }
                else 
                {
                    sum += num1[i];
                    C   
                }
            }
        }


           


    }
}