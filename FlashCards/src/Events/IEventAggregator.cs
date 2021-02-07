using System;

namespace src
{
    public interface IEventAggregator
    {
        void Dispose();
        void Subscribe<T>(Action<T> action) where T : IApplicationEvent;
        void UnSubscribe<T>(Action<T> action) where T : IApplicationEvent;
    }
}