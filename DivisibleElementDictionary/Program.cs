using System;
using System.Collections.Generic;
namespace DivisibleElementDictionary
{
    class DivisibleDictionary
    {

        public static Dictionary<int, int> CreateDivisibleDictionary(List<int[]> arrayList, int number)
        {
            Dictionary<int, int> KeyOccuranceDictionary = new Dictionary<int, int>();

            if (arrayList.Count > 0 && number > 0)
            {

                foreach (int[] array in arrayList)
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] % number == 0)
                        {
                            if (!KeyOccuranceDictionary.ContainsKey(array[i]))
                            {//adding first occurance of divisble number
                                KeyOccuranceDictionary.Add(array[i], 1);
                            }
                            else
                            {
                                //adding next occurance of divisble number
                                KeyOccuranceDictionary[array[i]]++;
                            }
                        }

                    }

                }
            }
            return KeyOccuranceDictionary;
        }
    }
    


    class Program
    {

        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int[]> arraycollection = new List<int[]>();
            arraycollection.Add(new int[] { 10, 12, 14, 40, 60, 65, 80, 90 });
            arraycollection.Add(new int[] { 3, 4, 65, 40, 40, 30, 20 });
            arraycollection.Add(new int[] { 120, 400, 80, 90, 20, 60 });
            var resultDictionary =DivisibleDictionary.CreateDivisibleDictionary(arraycollection, 5);
            if (resultDictionary.Count > 0)
            {
                foreach (var keyValue in resultDictionary)
                {
                    Console.Write("{0}:{1}, ", keyValue.Key, keyValue.Value);
                    
                }
            }


        }
    }
}
