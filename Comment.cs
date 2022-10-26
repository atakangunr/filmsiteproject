using System;
using System.ComponentModel.DataAnnotations;

namespace Proje
{
    public class Comment : BaseEntity
    {
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }

        public Comment()
        {

        }
    }
}
