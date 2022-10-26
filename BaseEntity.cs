using System.ComponentModel.DataAnnotations;

namespace Proje
{
    public class BaseEntity
    {

        [Key]
        public int Id { get; set; }

        public BaseEntity()
        {

        }
    }
}
