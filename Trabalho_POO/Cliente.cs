using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    public class Cliente
    {
        private String nome;
        private String email;
        private String telefone;
        private String documentoIdentificacao;

        // Construtor
        public Cliente(String nome, String email, String telefone, String documentoIdentificacao)
        {
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
            this.documentoIdentificacao = documentoIdentificacao;
        }

        // Getters e Setters
        public String getNome()
        {
            return nome;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }
    }
}

