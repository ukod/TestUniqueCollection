using System;

namespace UniqCollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UniqueCollection<int> uniqueList = new UniqueCollection<int>();

            for (int i = 0; i < 30; i++)
            {
                uniqueList.Add(i);
            }

            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine(uniqueList[i]);
            }
            Console.Read();
        }
    }
}
