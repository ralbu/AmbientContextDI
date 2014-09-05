using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProvider
{
    public abstract class TimeProvider
    {
        private static TimeProvider current;

        static TimeProvider()
        {
            TimeProvider.current = new DefaultTimeProvider();
        }

        private static TimeProvider Current
        {
            get { return TimeProvider.current; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("value");
                }

                TimeProvider.current = value;
            }
        }

        public abstract DateTime UtcNow { get; }

        public static void ResetToDefault()
        {
            TimeProvider.current = new DefaultTimeProvider();
        }
    }
}
