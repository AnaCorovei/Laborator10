using System;
namespace Laborator10.Interfaces
{
    class Phone : IContactLessPayment
    {
        public void EfectueazaPlata()
        {
            Console.WriteLine("Efectual plata");
        }

        public void ApropieDispozitiv()
        {
            Console.WriteLine("Apropie telefonul");
        }

    }

}

