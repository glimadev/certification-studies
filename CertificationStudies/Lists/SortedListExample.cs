using System;
using System.Collections;

namespace CertificationStudies
{
    public class SortedListExample
    {
        public void Run()
        {
            //Represents a collection of key / value pairs that are sorted by the keys and are accessible by key and by index.

            SortedList mySL = new SortedList();
            mySL.Add("B", "!");
            mySL.Add("D", "World");
            mySL.Add("A", "Hello");

            // Displays the properties and values of the SortedList.
            Console.WriteLine("mySL");
            Console.WriteLine("  Count:    {0}", mySL.Count);
            Console.WriteLine("  Capacity: {0}", mySL.Capacity);
            Console.WriteLine("  Keys and Values:");

            Console.WriteLine("\t-KEY-\t-VALUE-");

            for (int i = 0; i < mySL.Count; i++)
            {
                Console.WriteLine("\t{0}:\t{1}", mySL.GetKey(i), mySL.GetByIndex(i));
            }

            Console.WriteLine();
        }
    }
}
