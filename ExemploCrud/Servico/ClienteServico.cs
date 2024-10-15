using ExemploCrud.Core.Entidades;
using ExemploCrud.Infra.Repositorio;

namespace ExemploCrud.Servico
{
    internal class ClienteServico
    {
        private readonly ClienteRepositorio _clienteRepositorio;

        public ClienteServico(ClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public void AdicionarCliente(Cliente cliente)
        {
            _clienteRepositorio.AdicionarCliente(cliente);
        }

        public void EditarCliente(int clienteId, string novoNome, string novoEmail, DateTime novaDataNascimento)
        {
            var cliente = _clienteRepositorio.GetClientes().FirstOrDefault(x => x.Id == clienteId);
            if (cliente != null)
            {
                cliente.Nome = novoNome;
                cliente.Email = novoEmail;
                cliente.DataNascimento = novaDataNascimento;
                _clienteRepositorio.AtualizarCliente(cliente);
            }
        }

        public void DeleteClienteFisico(int clienteId)
        {
            _clienteRepositorio.DeleteClienteFisico(clienteId);
        }

        public List<Cliente> GetClientes()
        {
            return _clienteRepositorio.GetClientes();
        }
    }
}