using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Tal_Tony_Gerbi.Exceptios
{
    public  class ExceptionsDemo
    {
        public static void Demo()
        {
            int[] arr = new int[2];
            arr[0] = 1;
            arr[1] = 2;
            try
            {
                arr[2] = 3;

            }
            catch (Exception ex)
            {
                Console.WriteLine("not work");
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("shit ");
            }
            ExceptionDestroyed Exdyd = new ExceptionDestroyed(5);
            Console.WriteLine(Exdyd);
        }
        public class ExceptionDestroyed: Exception
        {
            private int x;
            public ExceptionDestroyed(int x) : base("this is my Destroy Exception")
            {
                this.x = x;
            }
            public override string ToString()
            {
                return $"this {Message}" ;
            }
        }
    }
}
