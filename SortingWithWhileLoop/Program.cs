using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingWithWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortAscendWithWhile();
        }

        static void SortAscendWithWhile()
        {
            int[] arrarySort = new int[] { 100, 23, 45, 42, 17, 23 };

            int holder;

            var j = 0;

            while( j < arrarySort.Length)
            {
                int i = 0;
                while(i < arrarySort.Length - (j+1))
                {
                    if (arrarySort[i] > arrarySort[i + 1])
                    {
                        holder = arrarySort[i + 1];
                        arrarySort[i + 1] = arrarySort[i];
                        arrarySort[i] = holder;

                    }
                    i++;
                }

                j++;
            }
            

            for(var i = 0; i < arrarySort.Length; i++)
            {
                Console.WriteLine(arrarySort[i]);
            }
        }
    }
}
