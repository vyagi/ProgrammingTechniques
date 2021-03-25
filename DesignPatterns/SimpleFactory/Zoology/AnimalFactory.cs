using System;

namespace Zoology
{
    public class AnimalFactory
    {
        public DomesticAnimal Create<T>() where T : DomesticAnimal, new() => new T();

        // public DomesticAnimal Create(string type)
        // {
        //     var actualType = Type.GetType($"Zoology.{type}");
        //     return actualType == null ? null : (DomesticAnimal) Activator.CreateInstance(actualType);
        // }

        // public DomesticAnimal Create(string type) =>
        //     type switch
        //     {
        //         "Dog" => new Dog(),
        //         "Fish" => new Fish(),
        //         "Cat" => new Cat(),
        //         _ => null
        //     };
    }
}
