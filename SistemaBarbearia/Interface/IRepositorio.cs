using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBarbearia.Interface
{
	interface IRepositorio<T> where T: class
	{
        IEnumerable<T> Get();
        T Get(int id);
        void Create(T entidade);
        void Update(T entidade);
        void Delete(T entidade);
        int Savechange();
    }
}
