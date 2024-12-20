﻿using System.Collections;
using System.Text;

namespace FactoryMethod
{
    public abstract class Pizza
    {
        protected string Nome { get; set; }
        protected string Massa;
        protected string Molho;
        protected ArrayList ingredientes = new ArrayList();

        public string Preparar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Preparando" + Nome + "\n");
            sb.Append(Massa + "\n");
            sb.Append(Molho + "\n");
            sb.Append("Ingredientes: " + "\n");

            foreach (string ingrediente in ingredientes)
            {
                sb.Append("\t" + ingrediente + "\n");
            }

            sb.Append(Cozinhar());
            sb.Append(Fatiar());
            sb.Append(Embalar());

            return sb.ToString();
        }

        public virtual string Cozinhar()
        {
            return "Cozinhar por 25 minutos a 350 graus \n";
        }

        public virtual string Fatiar()
        {
            return "Fatiar a pizza em 8 pedaços \n";
        }

        public virtual string Embalar()
        {
            return "Embalar a pizza com embalagem oficial \n";
        }
    }
}