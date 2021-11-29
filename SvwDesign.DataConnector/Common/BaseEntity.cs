using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SvwDesign.DataConnector.Common
{
    public abstract class BaseEntity<TId>
    {
        [Key, Column(Order = 0)]
        public TId Id { get; set; }

        [ConcurrencyCheck, Column(Order = 204)]
        public byte[]? Version { get; set; }


        [Column(Order = 205)]
        public bool Active { get; set; } = true;

        public List<BaseDomainEvent> Events = new(); 
    }
}
