using System;

namespace PadraoObserver
{
    interface IObserver {
        void Update(string nome);
    }

    class ObserverRed : IObserver
    {
        public void Update(string nome)
        {
            var corAnterior = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(nome);
            Console.ForegroundColor = corAnterior;
        }
    }
    class ObserverBlue : IObserver
    {
        public void Update(string nome)
        {
            var corAnterior = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(nome);
            Console.ForegroundColor = corAnterior;
        }
    }
}