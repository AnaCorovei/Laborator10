using System;
using System.Collections.Generic;
using System.Text;
using Laborator10.Interfaces;

namespace Laborator10.Devices
{
    class Smartwatch : IContactLessPayment
    {
        public void ApropieDispozitiv()
        {
            Console.WriteLine("Apropie ceasul");
        }

        public void EfectueazaPlata()
        {
            Console.WriteLine("Platim");
        }
    }
}
