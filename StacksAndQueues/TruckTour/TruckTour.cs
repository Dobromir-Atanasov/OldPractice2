using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace TruckTour
{
    class TruckTour
    {
        static Queue<int> distance = new Queue<int>();
        static Queue<int> fuel = new Queue<int>();
        static void Main(string[] args)
        {
            int numberOfPumps = int.Parse(Console.ReadLine());
            GetPumpsFromConsoleAndPutThemToQueues(numberOfPumps);
            distance.TrimExcess();
            fuel.TrimExcess();
            for (int i = 0; i < numberOfPumps; i++)
            {
                if (CyclePumps())
                {
                    Console.WriteLine(i);
                    break;
                }
                distance.Enqueue(distance.Dequeue()); //one more step to start next iteration with new pump
                fuel.Enqueue(fuel.Dequeue());
            }
        }
        static bool CyclePumps()
        {
            bool result = true;
            bool alreadyFalse = false;
            BigInteger distanceToTravel = 0;
            BigInteger curentFuel = 0;
            for (int i = 0; i < distance.Count; i++)
            {
                distanceToTravel += distance.Peek();
                curentFuel += fuel.Peek();
                distance.Enqueue(distance.Dequeue());
                fuel.Enqueue(fuel.Dequeue());
                if (distanceToTravel>curentFuel&&!alreadyFalse)
                {
                    result = false;
                    alreadyFalse = true;
                }
            }
            return result;
        }
        static void GetPumpsFromConsoleAndPutThemToQueues(int numberOfPumps)
        {
            for (int i = 0; i < numberOfPumps; i++)
            {
                int[] tokenInputPump = Console.ReadLine()
                    .Split(' ')
                    .Select(x => int.Parse(x))
                    .ToArray();
                fuel.Enqueue(tokenInputPump[0]);
                distance.Enqueue(tokenInputPump[1]);
            }
        }
    }
}
//Commented solution is twice faster, but can't pass the second judge test, because of the Memory Limit!
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Numerics;

//namespace TruckTour
//{
//    class TruckTour
//    {
//        static Queue<int> distance = new Queue<int>();
//        static Queue<int> fuel = new Queue<int>();
//        static void Main(string[] args)
//        {
//            int numberOfPumps = int.Parse(Console.ReadLine());
//            GetPumpsFromConsoleAndPutThemToQueues(numberOfPumps);
//            distance.TrimExcess();
//            fuel.TrimExcess();
//            for (int i = 0; i < numberOfPumps; i++)
//            {
//                if (CyclePumps())
//                {
//                    Console.WriteLine(i);
//                    break;
//                }
//                distance.Enqueue(distance.Dequeue());
//                fuel.Enqueue(fuel.Dequeue());
//            }
//        }
//        static bool CyclePumps()
//        {
//            Queue<int> d = new Queue<int>(distance);
//            Queue<int> f = new Queue<int>(fuel);

//            BigInteger distanceToTravel = 0;
//            BigInteger curentFuel = 0;
//            for (int i = 0; i < distance.Count; i++)
//            {
//                distanceToTravel += d.Peek();
//                curentFuel += f.Peek();
//                d.Enqueue(d.Dequeue());
//                f.Enqueue(f.Dequeue());
//                if (distanceToTravel > curentFuel)
//                {
//                    return false;
//                }
//            }
//            return true;
//        }
//        static void GetPumpsFromConsoleAndPutThemToQueues(int numberOfPumps)
//        {
//            for (int i = 0; i < numberOfPumps; i++)
//            {
//                int[] tokenInputPump = Console.ReadLine()
//                    .Split(' ')
//                    .Select(x => int.Parse(x))
//                    .ToArray();
//                fuel.Enqueue(tokenInputPump[0]);
//                distance.Enqueue(tokenInputPump[1]);
//            }
//        }
//    }
//}
