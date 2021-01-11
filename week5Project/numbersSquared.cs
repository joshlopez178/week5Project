//Joshua Lopez
//CSOC 1320
//9-26-2019
//Week 5 project
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace week5Project
{
    class numbersSquared
    {

        public static void squares()
        {

           //

            try
            {
                TextWriter num = new StreamWriter("squaredNumbers.txt", true);
                num.WriteLine("here is the list", num );
                num.Close();
                Console.WriteLine("File Created..");

            }
            catch(Exception i)
            {
                Console.Write(i);

            }

            Console.Read();

        }
        

        
    }
}
