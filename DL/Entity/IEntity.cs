using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Entity
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }

    public interface IEntity
    {
        [Key]
        int Id { get; set; }
    }
}
