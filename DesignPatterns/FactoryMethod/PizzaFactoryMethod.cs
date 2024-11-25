namespace FactoryMethod
{
    public abstract class PizzaFactoryMethod
    {
        public Pizza MontaPizzaa(string tipo)
        {
            Pizza pizza;
            pizza = CriarPizza(tipo);
            return pizza;
        }

        protected abstract Pizza CriarPizza(string tipo);
    }
}
