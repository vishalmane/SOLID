using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LiskovSubstitutionPrinciple.Bad
{
    public class Animal
    {
        public virtual void Run()
        { }
    }
    public class Tiger : Animal
    {
    }
    public class Fish : Animal
    {
        public override void Run()
        {
            throw new Exception("I can not Run");
        }
    }

    public class DoSomething
    {
        public void AnimalMovement(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                if (animal is Tiger)
                    animal.Run();
            }
        }
    }

}
