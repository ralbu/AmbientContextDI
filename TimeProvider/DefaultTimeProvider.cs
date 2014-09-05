using System;

namespace TimeProvider
{
    public class DefaultTimeProvider : TimeProvider
    {
        public override DateTime UtcNow
        {
            get { return DateTime.UtcNow; }
        }
    }
}