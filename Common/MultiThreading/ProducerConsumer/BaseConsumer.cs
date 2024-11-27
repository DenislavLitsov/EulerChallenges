using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ProducerConsumer
{
    public abstract class BaseConsumer<T>
    {
        protected static Mutex mutex = new Mutex(false);

        private static bool solved = false;
        private readonly BaseProducer<T> producer;


        public BaseConsumer(BaseProducer<T> producer)
        {
            this.producer = producer;
            this.NullAnswers();
        }

        public static bool Solved { get => solved; protected set => solved = value; }

        public static T Answer { get; protected set; }

        public void Start()
        {
            while (!solved)
            {
                var nextValue = this.producer.GetNext();
                var result = this.Test(nextValue);
                if (result)
                {
                    mutex.WaitOne();
                    solved = result;
                    Answer = nextValue;
                    mutex.ReleaseMutex();

                    SafePrint.Print($"!!!SOLVED!!!!: {nextValue.ToString()}");
                }
            }
        }

        protected abstract bool Test(T item);

        protected abstract void NullAnswers();
    }
}
