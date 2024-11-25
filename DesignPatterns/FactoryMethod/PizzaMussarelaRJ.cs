namespace FactoryMethod
{
    public class PizzaMussarelaRJ : Pizza
    {
        public PizzaMussarelaRJ()
        {
            Nome = "Pizza de mussarela Carioca";
            Massa = "Massa fina crocante carioca";
            Molho = "Molho de tomate italiano paulista";
            ingredientes.Add("Queijo parmesão");
            ingredientes.Add("Azeitonas verdes");
        }
    }
}
