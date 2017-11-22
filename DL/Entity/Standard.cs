using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Entity
{

    public class Standard : BaseEntity
    {
        public Standard()
        {

        }

        public string StandardName { get; set; }

        public ICollection<Student> Students { get; set; }

    }
}
