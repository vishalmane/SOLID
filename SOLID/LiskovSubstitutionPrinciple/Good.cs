using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LiskovSubstitutionPrinciple.Good
{
  
    public class AnimalsCanRun
    {
        public void Run()
        {

        }
    }
    public class AnimalsCanSwim
    {
        public void Swim()
        {

        }
    }
    public class Tiger : AnimalsCanRun
    {
    }
    public class Fish : AnimalsCanSwim
    {
    }

    public class DoSomething
    {
        public void AnimalMovement(List<AnimalsCanRun> animals)
        {
            foreach (var animal in animals)
            {
                animal.Run();
            }
        }
        public void AnimalMovement(List<AnimalsCanSwim> animals)
        {
            foreach (var animal in animals)
            {
                animal.Swim();
            }
        }
    }
}
