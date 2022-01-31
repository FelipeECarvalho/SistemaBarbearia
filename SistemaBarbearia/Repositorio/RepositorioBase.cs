using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;

namespace SistemaBarbearia.Repositorio
{
	class RepositorioBase<T> where T : class
	{
		public IEnumerable<T> Get()
		{
			return Database.Connection.GetAll<T>();
		}

		public T Get(int id) 
		{
			return Database.Connection.Get<T>(id);
		}

		public virtual void Create(T model) 
		{
			Database.Connection.Insert<T>(model);
		}

		public void Update(T model) 
		{
			Database.Connection.Update<T>(model);
		}

		public void Delete(int id) 
		{
			var model = Get(id);
			Database.Connection.Delete<T>(model);
		}

		public void Delete(T model) 
		{
			Database.Connection.Delete<T>(model);
		}


		public DataTable GetDataTable(List<T> lista)
		{
			var propriedades = TypeDescriptor.GetProperties(typeof(T));
			var tabela = new DataTable();

			//Mapeamento das propriedades da classe para a tabela.

			for (int i = 0; i < propriedades.Count; i++) 
			{
				PropertyDescriptor propriedade = propriedades[i];


				if (propriedade.PropertyType.IsGenericType && propriedade.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
				{
					tabela.Columns.Add(propriedade.Name, propriedade.PropertyType.GetGenericArguments()[0]);
				}
				else 
				{
					tabela.Columns.Add(propriedade.Name, propriedade.PropertyType);
				}

			}

			var valores = new object[propriedades.Count];

			// Povoamento da tabela. Ele quebra o tipo complexo em tipos primitivos e insere na tabela nos seus respectivos campos.

			foreach (var item in lista)
			{
				for (int i = 0; i < valores.Length; i++) 
				{
					valores[i] = propriedades[i].GetValue(item);
				}

				tabela.Rows.Add(valores);
			}

			return tabela;
		}


	}
}
