using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Patterns
{
    interface IObservable
    {
        void AddObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();

    }
    interface IObserver // подписчик
    {
        void Update(Object ob);
    }
    //public class Observer
    //{
    //}

    class ConcreteObs: IObservable
    {
        private List<IObserver> observers;

        public ConcreteObs()
        {
            observers = new List<IObserver>(); 
        }

        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(null);
            }
        }        

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }
    }
    class Subscriber : IObserver
    {
        public void Update(object ob)
        {
            throw new NotImplementedException();
        }
    }

    public class ObserverRun
    {
        public static void Run()
        {

        }
    }
}
