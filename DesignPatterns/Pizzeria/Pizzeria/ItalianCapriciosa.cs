namespace Pizzeria
{
    public class ItalianCapriciosa : Pizza
    {
        public ItalianCapriciosa()
        {
            Name = "Italian Style Capriciosa";
            Dough = "Thin Crust Dough";
            Sauce = "Tomato Sauce";

            Toppings.Add("Shredded Mozzarella Cheese");
            Toppings.Add("Baked Ham");
            Toppings.Add("Mushroom");
            Toppings.Add("Aubergine");
            Toppings.Add("Tomatoes");
        }

        public override string Bake() => "Baking for 12 minutes in 230 Celsius degrees";

        public override string Cut() => "Cutting in 8 triangular slices";

        public override string Box() => "Boxing into fancy green, white and red box with Capriciosa";
    }
}
