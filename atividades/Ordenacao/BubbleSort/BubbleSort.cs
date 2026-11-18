using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BubbleSort
{
    
    public static void Sort<T>(T[] array) where T : IComparable
    {
        for( int i = 0; i < array.Lenght; i++)
        {
            for(int j = 0; < array.Lenght -1;)
        }
    }
}














private static void Swap<T>(T[] array, int first, int second)
        {
        T temp = array [first];
        array[first] = array [second];
        array[second] = temp;
        }