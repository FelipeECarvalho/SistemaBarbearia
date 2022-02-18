using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SistemaBarbearia.Data;
using SistemaBarbearia.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaBarbearia.Repositorio
{
	abstract class RepositorioBase<T> : IRepositorio<T> where T: class
	{
		protected BarbeariaDbContext _context;

		public void Create(T entidade)
		{
			try
			{
				using (_context = new BarbeariaDbContext())
				{
					_context.Set<T>().Add(entidade);
					Savechange();
				}
			}
			catch (SqlException) { OnRepositorioExceptionRaised("Não foi possível inserir. Verifique a conexão."); }
		}

		public void Delete(T entidade)
		{
			try
			{
				using (_context = new BarbeariaDbContext())
				{
					_context.Set<T>().Remove(entidade);
					Savechange();
				}
			}
			catch (SqlException) { OnRepositorioExceptionRaised("Não foi possível deletar. Verifique a conexão."); }
		}

		public void Update(T entidade)
		{
			try
			{
				using (_context = new BarbeariaDbContext())
				{
					_context.Entry<T>(entidade).State = EntityState.Modified;
					Savechange();
				}
			}
			catch (SqlException) { OnRepositorioExceptionRaised("Não foi possível atualizar. Verifique a conexão."); }
		}

		public IEnumerable<T> Get()
		{
			try
			{
				using (_context = new BarbeariaDbContext())
				{
					return _context.Set<T>().Select(a => a).ToList();
				}
			}
			catch (SqlException) { OnRepositorioExceptionRaised("Não foi possível ler. Verifique a conexão."); }

			return null;
		}

		public T Get(int id)
		{
			try
			{
				using (_context = new BarbeariaDbContext())
				{
					return _context.Set<T>().Find(id);
				}
			}
			catch (SqlException) { OnRepositorioExceptionRaised("Não foi possível ler. Verifique a conexão."); }

			return null;
		}

		public int Savechange()
		{
			try
			{
					return _context.SaveChanges();
			}
			catch (SqlException) { OnRepositorioExceptionRaised("Não foi possível salvar! Tente novamente."); }

			return 0;
		}

		protected void OnRepositorioExceptionRaised(string mensagem)
		{
			MessageBox.Show(mensagem, "ControleException", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		
	}
}
