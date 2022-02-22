using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemoCodeFirst
{
    public class Customer
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [MinLength(3)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        //[Column("LName")]
        public string LastName { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        //[ConcurrencyCheck]
        //public string Version { get; set; }

        public DateTime Created { get; set; }
    }
}
