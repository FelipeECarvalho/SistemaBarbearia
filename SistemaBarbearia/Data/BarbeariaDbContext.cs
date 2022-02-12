using Microsoft.EntityFrameworkCore;
using SistemaBarbearia.Modelo;

namespace SistemaBarbearia.Data
{
	class BarbeariaDbContext : DbContext
	{

		public DbSet<Administrador> Administradores { get; set; }
		public DbSet<Agendamento> Agendamentos { get; set; }
		public DbSet<Cliente> Clientes { get; set; }
		public DbSet<Servico> Servicos { get; set; }



		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Barbearia;UserId=sa;Password= 1q2w3e4r@#$;Trusted_Connection=False;TrustServerCertificate=True;");
		}
	}
}
