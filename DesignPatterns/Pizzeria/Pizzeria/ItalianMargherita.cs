namespace Pizzeria
{
    public class ItalianMargherita : Pizza
    {
        public ItalianMargherita()
        {
            Name = "Italian Style Margherita";
            Dough = "Thin Crust Dough";
            Sauce = "Plum Tomato Sauce";

            Toppings.Add("Shredded Mozzarella Cheese");
            Toppings.Add("Basil leaves");
        }

        public override string Bake() => "Baking for 10 minutes in 220 Celsius degrees";

        public override string Cut() => "Cutting in 8 triangular slices";

        public override string Box() => "Boxing into fancy green, white and red box";
    }
}
