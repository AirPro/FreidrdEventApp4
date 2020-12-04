﻿using FreidrdEventApp4.Models.DomainModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreidrdEventApp4.Models.DataLayer
{
	public class Repository<T> : IRepository<T> where T : Event
	{
		protected FreidrdFinalProjectContext context { get; set; }
		private DbSet<T> dbset { get; set; }

		public Repository(FreidrdFinalProjectContext ctx)
		{
			context = ctx;
			dbset = context.Set<T>();
		}

		public virtual IEnumerable<T> List(QueryOptions<T> options)
		{
			IQueryable<T> query = dbset;
			return query.ToList();
		}

		public virtual T get(int id) => dbset.Find(id);
		public virtual void Insert(T entity) => dbset.Add(entity);
		public virtual void Update(T entity) => dbset.Update(entity);
		public virtual void Delete(T entity) => dbset.Remove(entity);
		public virtual void Save() => context.SaveChanges();
	}
}
