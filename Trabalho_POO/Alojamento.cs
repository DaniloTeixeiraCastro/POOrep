using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    public class Alojamento
    {
        // Atributos
        private string nome;
        private string localizacao;
        private int capacidade;
        private double precoPorNoite;

        // Construtor
        public Alojamento(string nome, string localizacao, int capacidade, double precoPorNoite)
        {
            this.nome = nome;
            this.localizacao = localizacao;
            this.capacidade = capacidade;
            this.precoPorNoite = precoPorNoite;
        }

        // Propriedades (Getters e Setters)
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Localizacao
        {
            get { return localizacao; }
            set { localizacao = value; }
        }

        public int Capacidade
        {
            get { return capacidade; }
            set { capacidade = value; }
        }

        public double PrecoPorNoite
        {
            get { return precoPorNoite; }
            set { precoPorNoite = value; }
        }
    }

}
