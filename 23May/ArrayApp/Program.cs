using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayApp
{
    class Program
    {
        
        

        static void Main(string[] args)
        {

            
            const int size = 10;
            int[] number = new int[size];
            Console.WriteLine("Type a Value");
             


            string message = " ";

            for (int index = 0; index < number.Length; index++)
            {

                  

                message = message + "Value of Number [" + index + "] is" + " " + number[index] + "\n";
                
            }

            Console.WriteLine(message);
            Console.ReadKey();
        }

    }
}
