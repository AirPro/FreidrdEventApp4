using FreidrdEventApp4.Models.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FreidrdEventApp4.Models.DataLayer
{
	public class QueryOptions<T> where T : Event
	{
		public Expression<Func<T, Object>> OrderBy { get; set; }
	}
}
