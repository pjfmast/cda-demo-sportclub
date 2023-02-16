using Microsoft.AspNetCore.Mvc;
using SportClub.API.Extensions;
using SportClub.API.Repositories.Contracts;
using SportClub.Models.Dtos;

namespace SportClub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase // Controller extends ControllerBase with support for Views
    {
        private readonly ISportClubRepository workoutRepository;

        public ScheduleController(ISportClubRepository workoutRepository)
        {
            this.workoutRepository = workoutRepository;
        }

        [HttpGet]
        [Route(nameof(GetWorkouts))]
        public async Task<ActionResult<IEnumerable<WorkoutDto>>> GetWorkouts()
        {
            try
            {
                var workouts = await this.workoutRepository.GetWorkouts();

                if (workouts == null)
                {
                    return NotFound();
                }
                else
                {
                    var workoutDtos = workouts.ConvertToDto();

                    return Ok(workoutDtos);
                }

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");

            }
        }

        [HttpGet]
        [Route(nameof(GetLessonsBetween))]
        public async Task<ActionResult<LessonDto>> GetLessonsBetween(DateTime dateStart, DateTime dateEnd)
        {
            var locations = await this.workoutRepository.GetLocations();
            var workouts = await this.workoutRepository.GetWorkouts();

            var lessonsFound = await this.workoutRepository.GetSchedule(dateStart, dateEnd);
            var lessenDtos = lessonsFound.ConvertToDto(locations, workouts);

            return Ok(lessenDtos);

        }

        [HttpGet]
        [Route(nameof(GetTodaysLessons))]
        public async Task<ActionResult<LessonDto>> GetTodaysLessons()
        {
            DateTime startOfDay = DateTime.Now.StartOfDay();
            DateTime endOfDay = DateTime.Now.EndOfDay();
            
            return await GetLessonsBetween(startOfDay, endOfDay);
        }

    }
}
