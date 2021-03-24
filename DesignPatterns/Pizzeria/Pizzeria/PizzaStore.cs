namespace Pizzeria
{
    public class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza;

            if (type.Equals("margherita"))
            {
                pizza = new ItalianMargherita();
            }
            else if (type.Equals("capriciosa"))
            {
                pizza = new ItalianCapriciosa();
            }
            else return null;

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            
            return pizza;
        }
	}
}
