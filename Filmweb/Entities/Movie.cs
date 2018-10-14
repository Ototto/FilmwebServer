using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmweb.Entities
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public Genre Genre { get; set; }

        public string Description { get; set; }

        public string Boxoffice { get; set; }

        public DateTime PremiereWorldDate { get; set; }

        public DateTime PremierePolandDate { get; set; }

        public Cast Director { get; set; }

        public Cast Scenarist { get; set; }

        public Country Country1 { get; set; }

        public Country Country2 { get; set; }

        public Country Country3 { get; set; }
    }
}
