using System;
using System.Collections.Generic;

namespace PadraoObserver
{
    class SubjectBase : ISubject
    {
        List<IObserver> observers;

        public SubjectBase()
        {
            observers = new List<IObserver>();
        }
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Dettach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void DettachAll()
        {
            observers.RemoveAll(o => true);
        }

        public void Notify(string nome)
        {
            foreach (var observer in observers)
            {
                observer.Update(nome);
            } 
 
        }
    }
}