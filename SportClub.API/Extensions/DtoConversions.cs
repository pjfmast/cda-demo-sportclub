﻿using SportClub.API.Entities;
using SportClub.Models.Dtos;

namespace SportClub.API.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<WorkoutDto> ConvertToDto(this IEnumerable<Workout> workouts)
        {
            return (from workout in workouts
                    select new WorkoutDto
                    ( workout.Id,
                      workout.Title,
                      workout.Description,
                      workout.Category,
                      workout.Image,
                      workout.Duration,
                      workout.Price

                    )).ToList();
        }

        public static IEnumerable<LessonDto> ConvertToDto(this IEnumerable<Lesson> lessons, IEnumerable<Location> locations, IEnumerable<Workout> workouts)
        {
            return (from lesson in lessons
                    let workout = workouts.FirstOrDefault(workouts=> workouts.Id == lesson.WorkOutId)
                    let location = locations.FirstOrDefault(locations=> locations.Id == lesson.LocationId)
                    select new LessonDto
                    ( lesson.Id,
                      workout.Title,
                      workout.Description,
                      workout.Category,
                      workout.Image,
                      workout.Duration,
                      workout.Price,

                      lesson.StartDateTime,
                      location.Name,
                      lesson.Instructor
                    )).ToList();
        }
    }
}
