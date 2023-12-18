namespace Challenge12
{
    internal class Program
    {
        static void Main()
        {
            var producer = new Producer();
            List<Thread> threads = new List<Thread>();
            List<Consumer> consumers = new List<Consumer>();
            for (int i = 0; i < 7; i++)
            {
                var consumer = new Consumer(producer);
                consumers.Add(consumer);
                Thread thread = new Thread(consumer.Start);
                threads.Add(thread);
                thread.Start();
            }

            foreach (var thread in threads)
            {
                thread.Join();
            }
        }
    }
}