using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.InterfaceSegregationPrinciple.Bad
{
    interface IPhone
    {
        void Call();
        void Text();
        void Games();
        void Torch();
    }

    class SmartPhone : IPhone
    {
        public void Call()
        {
        }

        public void Text()
        {
        }

        public void Games()
        {
        }

        public void Torch()
        {
        }
    }

    class OldPhone : IPhone
    {       
       
        public void Torch()
        {
            throw new Exception("No torch Supports");
        }
        public void Call()
        {
        }

        public void Text()
        {
        }

        public void Games()
        {
            throw new Exception("No Game Supports");
        }
    }
}
