using System;
using Laborator10.Interfaces;   
namespace Laborator10.Devices
{
    class Card : IContactFullPayment
    {

        public void IntroduCardul()
        {
            Console.WriteLine("Introducem cardul");
        }

        public void ExtrageCardul()
        {
            Console.WriteLine("Extragem cardul");
        }

        public void EfectueazaPlata()
        {
            Console.WriteLine("Efectuam plata");
        }

    }

}

