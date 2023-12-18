using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Common.ProducerConsumer
{
    public abstract class BaseProducer<T>
    {
        Mutex mutex;

        public BaseProducer()
        {
            this.mutex = new Mutex(false);
        }

        public T GetNext()
        {
            this.mutex.WaitOne();
            var result = this.GenerateNext();
            mutex.ReleaseMutex();

            return result;
        }

        protected abstract T GenerateNext();
    }
}
