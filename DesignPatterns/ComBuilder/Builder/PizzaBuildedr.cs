using ComBuilder.Product;
using System.IO.Pipes;

namespace ComBuilder.Builder
{
    public abstract class PizzaBuildedr
    {
        protected Pizza pizza;

        public void CriaPizza()
        {
            pizza = new Pizza();
        }

        public  Pizza GetPizza()
        {
            return pizza;
        }

        public abstract void PreparaMassa();
        public abstract void IncluiIngredientes();
    }
}
