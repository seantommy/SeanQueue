using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeanQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            SeanQueue<string> namesQ = new SeanQueue<string>("1: Bob");

            namesQ.Push("2. Greg");
            namesQ.Push("3. Dan");
            namesQ.Push("4. Henry");

            namesQ.Pop();
            namesQ.Pop();
            namesQ.Pop();
            namesQ.Pop();

            namesQ.Push("1. Tim");
            namesQ.Push("2. Wendy");
            namesQ.Push("3. Doug");

            string namePolled = namesQ.Poll();
            namePolled = namesQ.Poll();
            namePolled = namesQ.Poll();
        }
    }
}
