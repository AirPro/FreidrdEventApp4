using FreidrdEventApp4.Models.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreidrdEventApp4.Models.DataLayer
{
	public interface IEventUnitOfWork
	{
		public Repository<Event> Events { get; }

		public void Save();
	}
}
