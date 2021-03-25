namespace Zoology
{
    public class AnimalFactory
    {
        public DomesticAnimal Create(string type) =>
            type switch
            {
                "Dog" => new Dog(),
                "Fish" => new Fish(),
                "Cat" => new Cat(),
                _ => null
            };
    }
}
