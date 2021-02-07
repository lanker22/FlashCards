using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace src
{
    /// <summary>
    ///     Provides global Event management .
    /// </summary>
    public class EventAggregator : IEventAggregator
    {
        private readonly ConcurrentDictionary<Type, List<object>> _subscriptions = new ConcurrentDictionary<Type, List<object>>();


        public void Register<T>() where T : IApplicationEvent
        {
            _subscriptions.TryAdd(typeof(T), new List<object>());
        }

        /// <summary>
        ///     Subscribe to a new or existig event.
        /// </summary>
        /// <typeparam name="T">Type of parameter to pass</typeparam>
        /// <param name="action">The Action<T> delegate to pass.</param>
        public void Subscribe<T>(Action<T> action) where T : IApplicationEvent
        {
            var subscribers = _subscriptions.GetOrAdd(typeof(T), t => new List<object>());
            subscribers.Add(action);
        }

        /// <summary>
        ///     Unsubscribe from an event
        /// </summary>
        /// <typeparam name="T">The parameter to pass and remove from the Aggregator.</typeparam>
        /// <param name="action">The Action<T> delegate parameter to remove from the Aggregator. </param>
        public void UnSubscribe<T>(Action<T> action) where T : IApplicationEvent
        {
            List<object> subscribers;
            if (_subscriptions.TryGetValue(typeof(T), out subscribers))
            {
                subscribers.Remove(action);
            }
        }

        /// <summary>
        ///     Clear all events.
        /// </summary>
        public void Dispose()
        {
            _subscriptions.Clear();
        }
    }
}
