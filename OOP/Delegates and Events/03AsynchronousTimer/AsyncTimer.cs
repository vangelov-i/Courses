using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03AsynchronousTimer
{
    public class AsyncTimer<T>
    {
        private Action<T> action;

        public AsyncTimer(Action<T> action, int ticks, int timeInterval)
        {

        }
    }
}
