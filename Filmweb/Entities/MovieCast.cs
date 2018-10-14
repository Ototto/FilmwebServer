namespace Filmweb.Entities
{
    public class MovieCast
    {
        public int Id { get; set; }

        public Cast Cast { get; set; }

        public Movie Movie { get; set; }

        public CastFunction Function { get; set; }
    }
}
