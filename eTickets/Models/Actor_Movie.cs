namespace eTickets.Models
{
    public class Actor_Movie
    {
        //MANY TO MANY FROM ACTOR AND MOVIE
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
