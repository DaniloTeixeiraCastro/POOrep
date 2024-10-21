using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    public class Reserva
    {
        // Atributos
        private Cliente cliente;
        private Alojamento alojamento;
        private DateTime dataCheckIn;
        private DateTime dataCheckOut;
        private bool confirmada;

        // Construtor
        public Reserva(Cliente cliente, Alojamento alojamento, DateTime dataCheckIn, DateTime dataCheckOut)
        {
            this.cliente = cliente;
            this.alojamento = alojamento;
            this.dataCheckIn = dataCheckIn;
            this.dataCheckOut = dataCheckOut;
            this.confirmada = false; // Inicia não confirmada 
        }

        // Propriedades (Getters e Setters)
        public Cliente Cliente
        {
            get { return cliente; }
        }

        public Alojamento Alojamento
        {
            get { return alojamento; }
        }

        public DateTime DataCheckIn
        {
            get { return dataCheckIn; }
            set { dataCheckIn = value; }
        }

        public DateTime DataCheckOut
        {
            get { return dataCheckOut; }
            set { dataCheckOut = value; }
        }

        public bool Confirmada
        {
            get { return confirmada; }
            set { confirmada = value; }
        }

        // Método para confirmar a reserva
        public void ConfirmarReserva()
        {
            this.confirmada = true;
        }
    }

}
