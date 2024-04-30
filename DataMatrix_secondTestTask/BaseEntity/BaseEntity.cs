using System.ComponentModel.DataAnnotations;

namespace DataMatrix_secondTestTask.BaseEntity
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
