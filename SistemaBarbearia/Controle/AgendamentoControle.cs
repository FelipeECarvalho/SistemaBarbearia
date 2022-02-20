using SistemaBarbearia.Modelo;
using SistemaBarbearia.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBarbearia.Controle
{
	class AgendamentoControle : ControleBase
	{
		private readonly AgendamentoRepositorio _agendamentoRepositorio;
		private readonly ServicoRepositorio _servicoRepositorio;

		public AgendamentoControle()
		{
			_agendamentoRepositorio = new AgendamentoRepositorio();
			_servicoRepositorio = new ServicoRepositorio();
		}


		public void Create(Agendamento agendamento)
		{
			try
			{
				if (agendamento.Servicos.Count == 0 || agendamento.Cliente == null || agendamento.Data.Hour == 0)
					throw new NullReferenceException();

				_agendamentoRepositorio.CreateWithServicos(agendamento);
				OnControleSuccessfullyAction("Agendamento criado com sucesso!", "Agendamento");

			}
			catch (NullReferenceException) { OnControleExceptionRaised("Agendamento não pode ser criado. Verifique os dados.", "Cliente"); }

		}

		public IEnumerable<Agendamento> Get()
		{
			return _agendamentoRepositorio.Get();
		}

		public IEnumerable<Agendamento> GetFull(string param)
		{
			try
			{
				return GetWithClientes().Where(x => x.NomeCliente.ToLower().Contains(param.ToLower())).ToList();
			}
			catch (NullReferenceException) { OnControleExceptionRaised("Não foi possivel recuperar os agendamentos. Verifique os dados.", "Cliente"); }

			return new List<Agendamento>();
		}



		public IEnumerable<Agendamento> GetWithClientes()
		{
			var agendamentos = _agendamentoRepositorio.GetWithClientes();
			foreach (var agendamento in agendamentos)
			{
				agendamento.InsertServico(_servicoRepositorio.GetByAgendamento(agendamento.Id).ToList());
			}
			return agendamentos;
		}

		public async Task<List<Agendamento>> GetMenuAsync(DateTime data)
		{
			return await _agendamentoRepositorio.GetMenuListAsync(data);
		}

		public IEnumerable<DateTime> GetDatasAgendadas(DateTime data)
		{
			return _agendamentoRepositorio.GetDatasAgendadas(data);
		}

		public void Delete(Agendamento agendamento)
		{
			try
			{
				if (agendamento.Id == 0) throw new NullReferenceException();

				if (MessageBox.Show("Tem certeza que deseja excluir o agendamento?", "Exclusão", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;

				_agendamentoRepositorio.Delete(agendamento);

				OnControleSuccessfullyAction("Agendamento excluído com sucesso!", "Agendamento");
			}
			catch (NullReferenceException) { OnControleExceptionRaised("Agendamento não pode ser criado. Verifique os dados.", "Cliente"); }
		}

	}
}
