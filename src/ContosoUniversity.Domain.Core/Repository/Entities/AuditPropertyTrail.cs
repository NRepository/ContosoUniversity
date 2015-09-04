namespace ContosoUniversity.Domain.Core.Repository.Entities
{
    using Models;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class AuditPropertyTrail : IEntity
    {
        public int EntityId { get; set; }

        [MaxLength(128)]
        [Required]
        public string EntityType { get; set; }

        public int ID { get; set; }

        [MaxLength(128)]
        [Required]
        public string ModifiedBy { get; set; } = CurrentPrincipalHelper.Name;

        public DateTime ModifiedDate { get; set; } = DateTimeHelper.Now;

        [MaxLength(128)]
        [Required]
        public string NewValue { get; set; }

        [MaxLength(128)]
        [Required]
        public string OldValue { get; set; }

        [MaxLength(128)]
        [Required]
        public string PropertyName { get; set; }
    }
}
