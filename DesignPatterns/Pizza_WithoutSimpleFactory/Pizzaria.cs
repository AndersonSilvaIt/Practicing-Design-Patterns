using System;

namespace Pizza_WithoutSimpleFactory
{
    public class Pizzaria
    {
        public static void SolicitaPizza()
        {
            PizzaCalabreza pizza1;
            PizzaMussarela pizza2;

            Console.WriteLine(" ===== Pizzaria =====");
            Console.WriteLine("Informe a Pizza (C)alabreza ou (M)ussarela \n");

            var pizzaEscolha = Console.ReadLine().ToUpper();

            if (pizzaEscolha.Equals("C"))
            {
                pizza1 = new PizzaCalabreza();
                pizza1.Preparar();
                pizza1.Assar(10);
                pizza1.Embalar();
                Console.WriteLine("pizza concluida");
            }
            else if (pizzaEscolha.Equals("M"))
            {
                pizza2 = new PizzaMussarela();
                pizza2.Preparar();
                pizza2.Assar(10);
                pizza2.Embalar();
                Console.WriteLine("pizza concluida");
            }
            else
            {
                Console.WriteLine("Opcao Invalida");
            }
        }
    }
}
