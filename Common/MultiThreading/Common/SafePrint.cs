using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ProducerConsumer
{
    public class SafePrint
    {
        static Mutex mutex = new Mutex(false);
        public static void Print(string toPrint)
        {
            mutex.WaitOne();
            Console.WriteLine(toPrint);
            mutex.ReleaseMutex();
        }
    }
}
