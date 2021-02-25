using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_LogicError
{
    class Program
    {

           public static void result(int n)
            {
            
                for (int num = 0; num < n; num++)
                {
                  
                    if (num % 3 == 0 && num % 5 == 0)
                   
                Console.Write(num + "23341668 ");


            }
        }

         
            static public void Main()
            {
                
                int n = 1000;
            Console.WriteLine("Enter the number between 1 and 1000");
            Console.ReadLine();

            result(n);
            }

   
    }
    }

