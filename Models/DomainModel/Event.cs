using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FreidrdEventApp4.Models.DomainModel
{
	public class Event
	{
        public int EventId { get; set; }

        [StringLength(50)]
        [Required]
        public string EventName { get; set; }

        [StringLength(50)]
        [Required]
        public string EventCity { get; set; }

        [StringLength(50)]
        [Required]
        public string EventDate { get; set; }

        [StringLength(50)]
        [Required]
        public string VenueName { get; set; }

        [StringLength(50)]
        [Required]
        public string VenueAddress { get; set; }

        [StringLength(50)]
        [Required]
        public string PromoterName { get; set; }
    }
}
