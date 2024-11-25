namespace FactoryMethod
{
    public class PizzaMussarelaSP : Pizza
    {
        public PizzaMussarelaSP()
        {
            Nome = "Pizza de mussarela Paulistana";
            Massa = "Massa fina crocante paulistana";
            Molho = "Molho de tomate italiano paulista";
            ingredientes.Add("Queijo parmesão");
            ingredientes.Add("Azeitonas verdes");
        }
    }
}
