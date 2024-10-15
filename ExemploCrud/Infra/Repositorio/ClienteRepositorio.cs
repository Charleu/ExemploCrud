using ExemploCrud.Core.Entidades;
using System;
using System.Collections.Generic;

namespace ExemploCrud.Infra.Repositorio
{
    internal class ClienteRepositorio
    {
        private static List<Cliente> clientes = new List<Cliente>();
        private static int _id = 0;

        public void AdicionarCliente(Cliente cliente)
        {
            cliente.Id = ++_id;
            clientes.Add(cliente);
        }

        public void AtualizarCliente(Cliente cliente)
        {
            var clienteExistente = clientes.FirstOrDefault(x => x.Id == cliente.Id);
            if (clienteExistente != null)
            {
                clienteExistente.Nome = cliente.Nome;
                clienteExistente.Sobrenome = cliente.Sobrenome;
                clienteExistente.Idade = cliente.Idade;
            }
        }

        public void DeleteClienteFisico(int clienteId)
        {
            var cliente = clientes.FirstOrDefault(x => x.Id == clienteId);
            if (cliente != null)
            {
                clientes.Remove(cliente);
            }
        }

        public List<Cliente> GetClientes()
        {
            return clientes;
        }
    }
}