﻿using System;

namespace ConcretePrototype
{
    public class Soldado : ICloneable
    {
        public string Nome { get; set; }
        public string Arma { get; set; }
        public Acessorio Acessorio { get; set; }

        public Soldado() { }

        public Soldado(Soldado s)
        {
            this.Nome = s.Nome;
            this.Arma = s.Arma;
            this.Acessorio = s.Acessorio;
        }

        public object Clone()
        {
            return new Soldado(this);
        }
    }
}
