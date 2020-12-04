using FreidrdEventApp4.Models.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreidrdEventApp4.Models.DataLayer
{
	public interface IRepository<T> where T : Event
	{
		IEnumerable<T> List(QueryOptions<T> options);
		T get(int id);
		void Insert(T entity);
		void Update(T entity);
		void Delete(T entity);
		void Save();
	}
}
