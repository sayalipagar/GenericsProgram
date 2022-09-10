using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgram
{
    internal class CreateArrray
    {
        public void createinpiut()
        {
            int[] intArr = { 1, 2, 3, 4, 5 };
            double[] doubleArr = { 1.0, 2.0, 3.0 };
            char[] charArr = { 'a', 'b', 'c', 'd', 'e', 'f' };

            PrintIntArr(intArr);
            PrintDoubleArr(doubleArr);
            PrintcharArr(charArr);
        }
        //Print Array
        static void PrintIntArr(int[] arr)
        {
            foreach (var data in arr)
            {
                Console.WriteLine(data);
            }
        }
        static void PrintDoubleArr(double[] arr)
        {
            foreach (var data in arr)
            {
                Console.WriteLine(data);
            }
        }
        static void PrintcharArr(char[] arr)
        {
            foreach (var data in arr)
            {
                Console.WriteLine(data);
            }
        }
    }
}
    

