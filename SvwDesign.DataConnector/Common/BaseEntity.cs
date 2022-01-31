using System;
using System.ComponentModel.DataAnnotations;

namespace SvwDesign.DataConnector.Common
{
    public abstract class BaseEntity<TId>
    {
        [Key]
        public TId? Id { get; set; }

        [ConcurrencyCheck]
        public byte[]? Version { get; set; }

        public bool Active { get; set; } = true;

        public DateTime Created { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? LastModified { get;  set; }

        public string? LastModifiedBy { get;  set; }
    }
}
