using SistemaBarbearia.Modelo;
using System.Collections.Generic;
using System.Linq;

namespace SistemaBarbearia.Repositorio
{
	class ClienteRepositorio : RepositorioBase
	{
		public void Create(Cliente cliente)
		{
			context.Clientes.Add(cliente);
			context.SaveChanges();
		}

		public Cliente Get(string cpf)
			=> context.Clientes.FirstOrDefault(x => x.Cpf == cpf);

		public Cliente Get(int id)
			=> context.Clientes.FirstOrDefault(x => x.Id == id);

		public IEnumerable<Cliente> Get()
			=> context.Clientes.ToList();

		public void Update(Cliente cliente)
		{
			context.Clientes.Update(cliente);
			context.SaveChanges();
		}

		public void Delete(Cliente cliente)
		{
			context.Clientes.Remove(cliente);
			context.SaveChanges();
		}
	}
}
