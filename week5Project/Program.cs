//Joshua Lopez 
//COSC 1320 001
//9-26-2019
//Week 5 Exam 1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace week5Project
{
    class Program
    {
        static void Main()
        {
            //I used this to get the squared values of the numbers
            
            Console.WriteLine("Here are the number values squared..");

            for (int i = 0; i < 101; i++)
            {
               

                Console.WriteLine("{0} {1}",
                    i.ToString().PadLeft(5, ' '), Math.Pow(i, 2));

                //This creates a .txt file with all the values printed on it

                TextWriter num = new StreamWriter("squaredNumbers.txt", true);
                num.WriteLine(i*i);
 
                num.Close();
            }

           
           
            Console.WriteLine("File Created..");


            Console.ReadKey();


        }
    }
}
