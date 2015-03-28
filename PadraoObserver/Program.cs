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
            var observerRed = new ObserverRed();
            var observerBlue = new ObserverBlue();
            var subject = new SubjectBase();
            subject.Attach(observerRed);
            subject.Attach(observerBlue);
            Console.WriteLine("Qual o seu nome?");
            string nome = Console.ReadLine();
            while (!string.IsNullOrEmpty(nome))
            {
                subject.Notify(nome);
                Console.WriteLine("Qual o seu nome?");
                nome = Console.ReadLine();
            
            }

        }
    }
}
