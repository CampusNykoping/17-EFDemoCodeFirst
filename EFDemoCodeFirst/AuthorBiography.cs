using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemoCodeFirst
{
    public class AuthorBiography
    {
        public int Id { get; set; }
        public string Biography { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Nationality { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

    }
}
