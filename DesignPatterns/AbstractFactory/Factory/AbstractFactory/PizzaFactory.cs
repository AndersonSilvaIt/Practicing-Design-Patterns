using AbstractFactory.Domain.Enums;
using AbstractFactory.Domain.Products;
using System;

namespace AbstractFactory.Factory.AbstractFactory
{
    public sealed class PizzaFactory : MassasAbstractFactory
    {
        public override MassaBase CriaMassa(TipoMassa tipoMassa)
        {
            var tipoBolo = (TipoPizza)tipoMassa;

            switch (tipoBolo)
            {
                case TipoPizza.Calabresas: return new PizzaCalabreza();
                case TipoPizza.Mussarela: return new PizzaMussarela();
                default:
                    throw new ArgumentOutOfRangeException("Tipo não implementado");
            }
        }
    }
}
