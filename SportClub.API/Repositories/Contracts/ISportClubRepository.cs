using SportClub.API.Entities;

namespace SportClub.API.Repositories.Contracts
{
    public interface ISportClubRepository
    {
        Task<IEnumerable<Location>> GetLocations();
        Task<IEnumerable<Workout>> GetWorkouts();
        Task<IEnumerable<Lesson>> GetSchedule(DateTime startDateTime, DateTime endDateTime);
    }
}
