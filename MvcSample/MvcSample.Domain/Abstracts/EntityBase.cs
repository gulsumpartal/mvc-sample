using System.ComponentModel.DataAnnotations;

namespace MvcSample.Domain.Abstracts
{
    public abstract class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
