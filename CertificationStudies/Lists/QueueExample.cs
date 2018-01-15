using System;
using System.Collections.Generic;

namespace CertificationStudies
{
    public class QueueExample
    {
        public void Run()
        {
            //Usado para processamento em fila
            //Use strongly typed members.
            //Process objects in first-in-first-out order.
            //Store values for each object.
            //Use zero-based indices.
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("one");
            queue.Enqueue("two");
            queue.Enqueue("three");
            queue.Enqueue("four");
            queue.Enqueue("five");

            // A queue can be enumerated without disturbing its contents.
            foreach (string number in queue)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nDequeuing '{0}'", queue.Dequeue());
            Console.WriteLine("Peek at next item to dequeue: {0}", queue.Peek());
            Console.WriteLine("Dequeuing '{0}'", queue.Dequeue());

            // Create a copy of the queue, using the ToArray method and the
            // constructor that accepts an IEnumerable<T>.
            Queue<string> queueCopy = new Queue<string>(queue.ToArray());

            Console.WriteLine("\nContents of the first copy:");
            foreach (string number in queueCopy)
            {
                Console.WriteLine(number);
            }
        }
    }
}
