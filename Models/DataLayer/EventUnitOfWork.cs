using FreidrdEventApp4.Models.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreidrdEventApp4.Models.DataLayer
{
    public class EventUnitOfWork : IEventUnitOfWork
    {
        private FreidrdFinalProjectContext context { get; set; }
        public EventUnitOfWork(FreidrdFinalProjectContext ctx) => context = ctx;

        private Repository<Event> eventData;
        public Repository<Event> Events
        {
            get
            {
                if (eventData == null)
                    eventData = new Repository<Event>(context);
                return eventData;
            }
        }

        public void Save() => context.SaveChanges();
    }
}
