using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgram
{
    //Generic Class
     class UsingGeneric
    {
        public void usingGeneric()
        {
            int[] intArr = { 1, 2, 3, 4, 5 };
            double[] doubleArr = { 1.0, 2.0, 3.0, 4.0, 5.0 };
            char[] charArr = { 'a', 'b', 'c', 'd', 'e', 'f' };
            PrintArr<int>(intArr);
            PrintArr<double>(doubleArr);
            PrintArr<char>(charArr);
            
        }
        static void PrintArr<T>(T[] arr)
        {
            foreach (var data in arr)
            {
                Console.WriteLine(data);
            }
        }
    }
}
    

