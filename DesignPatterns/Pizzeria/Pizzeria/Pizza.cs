using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public abstract class Pizza
    {
        public string Name { get; protected set; }
        protected string Dough { get; set; }
        protected string Sauce { get; set; }
        protected IList<string> Toppings { get; } = new List<string>();

        public virtual string Prepare()
        {
            var sb = new StringBuilder();

            sb.AppendLine("Preparing " + Name);
            sb.AppendLine("Tossing " + Dough);
            sb.AppendLine("Adding " + Sauce);
            sb.AppendLine("Adding toppings:");

            foreach (var topping in Toppings) 
                sb.AppendLine("\t" + topping);

            return sb.ToString();
        }

        public abstract string Bake();

        public abstract string Cut();

        public abstract string Box();
    }
}
