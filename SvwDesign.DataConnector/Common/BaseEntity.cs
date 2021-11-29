using System;
using System.Collections.Generic;

namespace SvwDesign.DataConnector.Common
{
    public abstract class BaseEntity<TId>
    {
        public TId Id { get; set; }
        public byte[]? Version { get; set; }
        public bool Active { get; set; } = true;

        public DateTime Created { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string? LastModifiedBy { get; set; }


        public List<BaseDomainEvent> Events = new(); 
    }
}
