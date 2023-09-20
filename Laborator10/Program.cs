using Laborator10.Devices;
using Laborator10.Interfaces;
using System;

namespace Laborator10
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card();
            Phone phone = new Phone();
            CardContactless cardContactless = new CardContactless();
            Smartwatch smartwatch = new Smartwatch();

            Pos pos = new Pos();
            pos.Plateste(card);
            pos.Plateste(cardContactless);
            pos.Plateste(smartwatch);
            pos.Plateste(phone);

            PosWOInterfaces posWOInterfaces = new PosWOInterfaces();
            posWOInterfaces.Plateste(card);
            posWOInterfaces.PlatesteContactless(phone);



        }
    }   
}

