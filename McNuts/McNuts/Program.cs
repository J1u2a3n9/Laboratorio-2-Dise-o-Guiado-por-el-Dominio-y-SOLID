using McNuts.Interfaces;
using McNuts.Notificador;
using System;

namespace McNuts
{
    class Program
    {
        static void Main(string[] args)
        {
            INotificador notificador;
            notificador = new Menu();
            notificador.Inicio();
        }
    }
}
