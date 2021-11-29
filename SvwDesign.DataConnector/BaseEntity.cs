using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SvwDesign.DataConnector
{
    public abstract class BaseEntity<TId>
    {
        [Key, Column(Order = 0)]
        public TId Id { get; set; }

        [Column(Order = 200)]

        public string? CreatedBy { get; set; }

        [Column(Order = 201)]

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        [Column(Order = 202)]
        public string? LastModifiedBy { get; set; }

        [Column(Order = 203)]
        public DateTime? LastModifiedOn { get; set; }

        [ConcurrencyCheck, Column(Order = 204)]
        public byte[]? Version { get; set; }


        [Column(Order = 205)]
        public bool Active { get; set; } = true;

        public List<BaseDomainEvent> Events = new(); 
    }
}
