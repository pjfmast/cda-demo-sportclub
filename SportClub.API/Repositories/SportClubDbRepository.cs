using Microsoft.EntityFrameworkCore;
using SportClub.API.Data;
using SportClub.API.Entities;
using SportClub.API.Repositories.Contracts;

namespace SportClub.API.Repositories
{
    public class SportClubDbRepository : ISportClubRepository
    {
        private readonly SportClubDbContext sportClubDbContext;

        public SportClubDbRepository(SportClubDbContext sportClubDbContext)
        {
            this.sportClubDbContext = sportClubDbContext;
        }
        public async Task<IEnumerable<Location>> GetLocations()
        {
            return await sportClubDbContext.Locations.ToListAsync();
        }

        public async Task<IEnumerable<Workout>> GetWorkouts()
        {
            return await sportClubDbContext.workouts.ToListAsync();
        }

        public async Task<IEnumerable<Lesson>> GetSchedule(DateTime startDateTime, DateTime endDateTime)
        {
            var found = new List<Lesson>();
            found = await sportClubDbContext.lessons
                .Where((Lesson w) => w.StartDateTime >= startDateTime && w.StartDateTime <= endDateTime)
                .ToListAsync();

            return found;
        }

    }
}
