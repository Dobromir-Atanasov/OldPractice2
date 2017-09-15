using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace CalculateSequenceWithQueue
{        
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger token = BigInteger.Parse(Console.ReadLine());
            Queue<BigInteger> s = new Queue<BigInteger>();
            Queue<BigInteger> q = new Queue<BigInteger>();

            s.Enqueue(token);
            q.Enqueue(token);
            
            int counter = 0;
            while (counter<50)
            {
                q.Enqueue(s.Peek() + 1);
                s.Enqueue(s.Peek() + 1);
                q.Enqueue(s.Peek() * 2 + 1);
                s.Enqueue(s.Peek() * 2 + 1);
                q.Enqueue(s.Peek() + 2);
                s.Enqueue(s.Dequeue() + 2);
                counter += 3;
            }
            for (int i = 0; i < 50; i++)
            {
                Console.Write(q.Dequeue() + " ");
            }
        }
    }
}
