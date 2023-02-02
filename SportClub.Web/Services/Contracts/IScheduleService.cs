using SportClub.Models.Dtos;

namespace SportClub.Web.Services.Contracts
{
    public interface IScheduleService
    {
        Task<IEnumerable<LessonDto>> GetTodaysLessons();
    }
}
