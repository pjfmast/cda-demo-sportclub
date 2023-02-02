namespace SportClub.API.Entities
{
    public class Lesson
    {
        public int Id { get; set; }
        public int WorkOutId { get; set; }
        public int LocationId { get; set; }

        public required string Instructor { get; set; }
        public DateTime StartDateTime { get; set; }

    }
}
