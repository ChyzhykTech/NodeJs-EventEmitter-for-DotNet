using System;
using System.Collections.Generic;

namespace EventEmitter
{
    public sealed class EventEmitter : IEventEmitter
    {
        private readonly Dictionary<string, List<Action<object[]>>> events = new Dictionary<string, List<Action<object[]>>>();

        public void AddListener(string eventName, Action<object[]> listener)
        {
            if(this.events.TryGetValue(eventName, out List<Action<object[]>> listeners))
            {
                listeners.Add(listener);
                this.events[eventName] = listeners;
            }
            else
            {
                this.events.Add(eventName, new List<Action<object[]>> { listener });
            }
        }

        public bool Emit(string eventName, object[] args)
        {
            if (this.events.TryGetValue(eventName, out List<Action<object[]>> listeners)) 
            {
                foreach(var listener in listeners)
                {
                    listener(args);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEventEmitter On(string eventName, Action<object[]> listener)
        {
            if (this.events.TryGetValue(eventName, out List<Action<object[]>> listeners))
            {
                listeners.Add(listener);
                this.events[eventName] = listeners;
            }
            else
            {
                this.events.Add(eventName, new List<Action<object[]>> { listener });
            }

            return this;
        }
    }
}
