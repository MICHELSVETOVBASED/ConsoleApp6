using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class MainClass
{
    public static void Main()
    {
        string num = Console.ReadLine();
        string num1 = Console.ReadLine();
        string s = "";
        

        for ( int i = 0; i<num.Length; i++ )
        {
            int count = 0;
            for (int j = 0; j < num.Length; j++)
            {
                if (num[i] == num[j])
                {
                    for (int k = 0; k<num1.Length;k++)
                    {
                        if (num[i] == num1[k])
                            count++;

                    }
                    count++;
                }

            }
            if(count == 1)
            {
                s += num[i] + " ";
            }
            
        }
        Console.WriteLine(s);
        Console.WriteLine(s);
        Console.WriteLine(s);
    }
}