using System;
using System.Collections.Generic;
using System.Text;

namespace Lista.CursoCsharp
{
    class Produtos
    {
        private string Nome;
        private double Preco;
        private int Quantidade;
        public void Add(string nome, double preco, int quantidade = 0)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string ToText()
        {
            string resultado;
            return resultado = Nome + ", " + Preco + ", " + Quantidade;
        }

        public string Noome
        {
            get { 
                return Nome; 
            }
            set { 
                if (value.Length > 1) Nome = value; 
            }
        }

        public double Prreco {
            set {
                if (value >= 0) Preco = value; 
            }
            get {
                return Preco; 
            }
        }

        public int Quuantidade {
            set {
                
                if (Quantidade >= 0) Quantidade = value; }
            get {
                return Quantidade; 
            }
        }

    }
}
