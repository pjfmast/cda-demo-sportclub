namespace SportClub.Models.Dtos
{
    // beste practice: use C#9 records for DTO's.
    // see: https://stackoverflow.com/questions/64816714/when-to-use-record-vs-class-vs-struct
    // for working with record type: https://www.infoworld.com/article/3607372/how-to-work-with-record-types-in-csharp-9.html
    public record WorkoutDto
    (
        int Id,
        string Title,
        string Description,
        string Category,
        string? Image,
        int Duration,
        decimal? Price
    );

}
