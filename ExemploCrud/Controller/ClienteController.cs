using ExemploCrud.Core.Entidades;
using ExemploCrud.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploCrud.Controller
{
    internal class ClienteController
    {
        private readonly ClienteServico _clienteServico;

        public ClienteController(ClienteServico clienteServico)
        {
            _clienteServico = clienteServico;
        }

        public void AdicionarCliente(string nome, string sobrenome, int idade)
        {
            var cliente = new Cliente
            {
                Nome = nome,
                Sobrenome = sobrenome,
                Idade = idade
            };

            _clienteServico.AdicionarCliente(cliente);
        }

        public List<Cliente> ListarClientes()
        {
            return _clienteServico.GetClientes();
        }

        public void EditarCliente(int clienteId, string novoNome, string novoSobrenome, int novaIdade, string novoEmail, DateTime novaDataNascimento)
        {
            _clienteServico.EditarCliente(clienteId, novoNome, novoEmail, novaDataNascimento);
        }

        public void DeleteClienteFisico(int clienteId)
        {
            _clienteServico.DeleteClienteFisico(clienteId);
        }
    }
}