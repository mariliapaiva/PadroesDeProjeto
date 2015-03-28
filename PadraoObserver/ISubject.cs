namespace PadraoObserver
{
    interface ISubject {
        void Attach( IObserver observer);
        void Dettach( IObserver observer);
        void DettachAll();
        void Notify(string nome);

    }
}