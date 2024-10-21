using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    using System;
    using System.Collections.Generic;

    public class SistemaGestaoAlojamento
    {
        private List<Cliente> clientes;
        private List<Alojamento> alojamentos;
        private List<Reserva> reservas;

        // Construtor
        public SistemaGestaoAlojamento()
        {
            clientes = new List<Cliente>();
            alojamentos = new List<Alojamento>();
            reservas = new List<Reserva>();
        }

        // Métodos para adicionar clientes, alojamentos, reservas
        public void AdicionarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public void AdicionarAlojamento(Alojamento alojamento)
        {
            alojamentos.Add(alojamento);
        }

        public void FazerReserva(Cliente cliente, Alojamento alojamento, DateTime checkIn, DateTime checkOut)
        {
            Reserva novaReserva = new Reserva(cliente, alojamento, checkIn, checkOut);
            reservas.Add(novaReserva);
        }

        // Consultar reservas
        public List<Reserva> ConsultarReservas()
        {
            return reservas;
        }

        // Verificar disponibilidade de alojamento
        public bool VerificarDisponibilidade(Alojamento alojamento, DateTime checkIn, DateTime checkOut)
        {
            foreach (var reserva in reservas)
            {
                if (reserva.Alojamento == alojamento &&
                    ((checkIn >= reserva.DataCheckIn && checkIn <= reserva.DataCheckOut) ||
                     (checkOut >= reserva.DataCheckIn && checkOut <= reserva.DataCheckOut)))
                {
                    return false;
                }
            }
            return true;
        }
    }

}
