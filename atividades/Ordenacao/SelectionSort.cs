using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks



namespace SelectionSort
{
    public static class SelectionSort
    {
        
        public static void Sort(<T>[] array)
            where T : IComparabl<T>
        {
            for (int i=0; i < array.Lenght -1; i++)
            {
                int minINDEX = i;
                T minValue = array[i];

                for(int j = i +1; j < array.Lenght; j++)
                {
                    if(array[j].CompareTo(minValue) < 0)
                    {
                        minINDEX = j;
                        minValue = array[j];
                    }
                }
                
                Swap(array, i, minINDEX Index);
            }
        }
        private static void Swap<T>(T[]), int first, int second
        {
            T temp= array[first];
            array[first] = array [second];
            array[second] = temp;
        }
        
    }
}