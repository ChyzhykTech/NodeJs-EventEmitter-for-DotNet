using System;
using System.Collections.Generic;

namespace EventEmitter
{
    public interface IEventEmitter
    {
        //addListener(eventName: string | symbol, listener: (...args: any[]) => void): this;
        void AddListener(string eventName, Action<object[]> listener);

        // on(eventName: string | symbol, listener: (...args: any[]) => void): this;
        IEventEmitter On(string eventName, Action<object[]> listener);

        // emit(eventName: string | symbol, ...args: any[]) : boolean;
        bool Emit(string eventName, object[] args);





        
                
        
                
        //        once(eventName: string | symbol, listener: (...args: any[]) => void): this;
                
        //        removeListener(eventName: string | symbol, listener: (...args: any[]) => void): this;
                
        //        off(eventName: string | symbol, listener: (...args: any[]) => void): this;
                
        //        removeAllListeners(event?: string | symbol): this;
                
        //        setMaxListeners(n: number) : this;
        
        //getMaxListeners() : number;
                
        //        listeners(eventName: string | symbol) : Function[];
                
        //        rawListeners(eventName: string | symbol) : Function[];
               
                
        //        listenerCount(eventName: string | symbol) : number;
                
        //        prependListener(eventName: string | symbol, listener: (...args: any[]) => void): this;
                
        //        prependOnceListener(eventName: string | symbol, listener: (...args: any[]) => void): this;
                
        //        eventNames() : Array<string | symbol>;
    }
}
