using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoObserver
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface IObserver {
        void Update();
    }
    interface ISubject {
        void Attach( IObserver observer);
        void Dettach( IObserver observer);
        void DettachAll();
        void Notify();

    }

    class ObserverBase : IObserver
    {
        public void Update()
        {
            throw new NotImplementedException();
        }
    }

    class SubjectBase : ISubject
    {
        public void Attach(IObserver observer)
        {
            throw new NotImplementedException();
        }

        public void Dettach(IObserver observer)
        {
            throw new NotImplementedException();
        }

        public void DettachAll()
        {
            throw new NotImplementedException();
        }

        public void Notify()
        {
            throw new NotImplementedException();
        }
    }
}
