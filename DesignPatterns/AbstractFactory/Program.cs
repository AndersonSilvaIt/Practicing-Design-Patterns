using AbstractFactory.Domain.Enums;
using AbstractFactory.Domain.Products;
using AbstractFactory.Factory.AbstractFactory;
using System;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Obtém as fábricas
            var boloFactory = MassasAbstractFactory.CriaFabricaMassas(TipoMassa.Bolo);
            var pizzaFactory = MassasAbstractFactory.CriaFabricaMassas(TipoMassa.Pizza);

            // Cria objetos com base n otipo : bolo

            var bolo1 = boloFactory.CriaMassa((TipoMassa)TipoBolo.Chocolate);
            var bolo2 = boloFactory.CriaMassa((TipoMassa)TipoBolo.Laranja);

            // cria os objetos com base no tipo: Pizza
            var pizza1 = pizzaFactory.CriaMassa((TipoMassa)TipoPizza.Mussarela);
            var pizza2 = pizzaFactory.CriaMassa((TipoMassa)TipoPizza.Calabresas);

            // Exibe os detalhes
            ExiveDetalhes(bolo1);
            ExiveDetalhes(bolo2);
            ExiveDetalhes(pizza1);
            ExiveDetalhes(pizza2);

            Console.ReadLine();
        }

        static void ExiveDetalhes(MassaBase massaBase)
        {
            Console.WriteLine($"Tipo : {massaBase.TipoMassa} ");
            Console.WriteLine(massaBase.Nome);
            Console.WriteLine(massaBase.Ingredientes[0].ToString());
            Console.WriteLine("\n");
        }
    }
}