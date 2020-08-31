using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.InterfaceSegregationPrinciple.Good
{
    interface IPhone
    {
        void Call();
        void Text();
    }
    interface IGames
    {
        void Games();
    }
    interface ITorch
    {
        void Torch();
    }

    class smartPhone : IPhone, IGames, ITorch
    {
        public void Call()
        {
        }
        public void Games()
        {
        }
        public void Text()
        {
        }
        public void Torch()
        {
        }
    }
    class OldPhone : IPhone
    {
        public void Call()
        {
        }
        public void Text()
        {
        }
    }
}
