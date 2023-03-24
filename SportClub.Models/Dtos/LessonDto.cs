using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportClub.Models.Dtos
{
    // beste practice: use C#9 records for DTO's.
    // see: https://stackoverflow.com/questions/64816714/when-to-use-record-vs-class-vs-struct
    // for working with record type: https://www.infoworld.com/article/3607372/how-to-work-with-record-types-in-csharp-9.html

    // BUT: Blazor model binding and validation is not supported (yet)
    //     when using a record-type, see: https://github.com/dotnet/aspnetcore/issues/31604
    public record LessonDto(
        int Id,
        string Title,
        string Description,
        string Category,
        string? Image,
        int Duration,
        decimal? Price,

        // A lesson is a scheduled and located workout with an instructor
        DateTime StartTime,
        string Location,
        string Instructor
        );
}
