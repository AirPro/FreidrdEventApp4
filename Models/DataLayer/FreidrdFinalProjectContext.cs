using FreidrdEventApp4.Models.DomainModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreidrdEventApp4.Models.DataLayer
{
	public class FreidrdFinalProjectContext : DbContext
	{
		public FreidrdFinalProjectContext(DbContextOptions<FreidrdFinalProjectContext> options)
			: base(options)
		{
		}

		public virtual DbSet<Event> Events { get; set; }
	}
}
