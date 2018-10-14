using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmweb.Entities
{
    public class Cast
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime BirthDate { get; set; }

        public int Height { get; set; }

        public string BirthPlace { get; set; }

        public string MaritalStatus { get; set; }

        public string ImageLink { get; set; }
    }
}
