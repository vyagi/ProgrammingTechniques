using System;

namespace Zoology
{
    public class AnimalFactory
    {
        public DomesticAnimal Create(string type)
        {
            if (type == "Dog")
            {
                return new Dog();
            }

            if (type == "Cat")
            {
                return new Cat();
            }

            if (type == "Fish")
            {
                return new Fish();
            }

            return null; //Bad idea in general
        }
    }
}
