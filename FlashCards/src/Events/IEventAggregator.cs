using System;

namespace src
{
    public interface IEventAggregator
    {
        void Dispose();
        void Publish<T>(T message) where T : IApplicationEvent;
        void Subscribe<T>(Action<T> action) where T : IApplicationEvent;
        void UnSubscribe<T>(Action<T> action) where T : IApplicationEvent;
    }
}