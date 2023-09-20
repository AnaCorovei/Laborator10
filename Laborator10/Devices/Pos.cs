using System;
using Laborator10.Devices;
using Laborator10.Interfaces;
namespace Laborator10
{
    class PosWOInterfaces //pos fara interfete
    {
        public void Plateste(Card card)
        {
            card.IntroduCardul();
            card.EfectueazaPlata();
            card.ExtrageCardul();
        }

        public void PlatesteContactless(Phone phone)
        {
            phone.ApropieDispozitiv();
            phone.EfectueazaPlata();
        }

        public void PlatesteContactless(CardContactless cardContactless)
        {
            cardContactless.ApropieDispozitiv();
            cardContactless.EfectueazaPlata();

        }

        public void PlatesteContactless(Smartwatch cardContactless)
        {
            cardContactless.ApropieDispozitiv();
            cardContactless.EfectueazaPlata();

        }
    }

    class Pos
    {
        public void Plateste(IContactLessPayment card)
        {
            card.ApropieDispozitiv();
            card.EfectueazaPlata();
        }

        public void Plateste(IContactFullPayment card)
        {
            card.IntroduCardul();
            card.EfectueazaPlata();
            card.ExtrageCardul();
        }
    }

}

