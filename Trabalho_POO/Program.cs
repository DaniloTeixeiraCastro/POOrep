using System;
using Trabalho_POO;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando o sistema de gestão de alojamentos
            SistemaGestaoAlojamento sistema = new SistemaGestaoAlojamento();

            // Criando e adicionando clientes
            Cliente cliente1 = new Cliente("João Silva", "joao@example.com", "912345678", "123456789");
            Cliente cliente2 = new Cliente("Maria Pereira", "maria@example.com", "987654321", "987654321");

            sistema.AdicionarCliente(cliente1);
            sistema.AdicionarCliente(cliente2);

            // Criando e adicionando alojamentos
            Alojamento alojamento1 = new Alojamento("Alojamento Centro", "Porto", 4, 75.00);
            Alojamento alojamento2 = new Alojamento("Casa Vista Mar", "Lisboa", 2, 120.00);

            sistema.AdicionarAlojamento(alojamento1);
            sistema.AdicionarAlojamento(alojamento2);

            // Fazendo uma reserva
            DateTime checkIn = new DateTime(2024, 12, 1);
            DateTime checkOut = new DateTime(2024, 12, 5);
            sistema.FazerReserva(cliente1, alojamento1, checkIn, checkOut);

            // Exibindo as reservas
            Console.WriteLine("Reservas feitas:");
            foreach (var reserva in sistema.ConsultarReservas())
            {
                Console.WriteLine($"Cliente: {reserva.Cliente.setNome}, Alojamento: {reserva.Alojamento.Nome}, Check-In: {reserva.DataCheckIn.ToShortDateString()}, Check-Out: {reserva.DataCheckOut.ToShortDateString()}");
            }

            // Verificando disponibilidade de alojamento
            DateTime novaDataCheckIn = new DateTime(2024, 12, 3);
            DateTime novaDataCheckOut = new DateTime(2024, 12, 7);

            bool disponibilidade = sistema.VerificarDisponibilidade(alojamento1, novaDataCheckIn, novaDataCheckOut);
            Console.WriteLine($"Disponibilidade do alojamento '{alojamento1.Nome}' entre {novaDataCheckIn.ToShortDateString()} e {novaDataCheckOut.ToShortDateString()}: {disponibilidade}");
        }


    }
}