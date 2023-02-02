using SportClub.Models.Dtos;
using SportClub.Web.Services.Contracts;
using System.Net.Http.Json;

namespace SportClub.Web.Services
{
    public class ScheduleService : IScheduleService
    {
        private readonly HttpClient httpClient;

        public ScheduleService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<LessonDto>> GetTodaysLessons()
        {
            try
            {
                // https://localhost:7296/api/Schedule/GetTodaysLessons
                var response = await httpClient.GetAsync("api/Schedule/GetTodaysLessons");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return Enumerable.Empty<LessonDto>();
                    }

                    return await response.Content.ReadFromJsonAsync<IEnumerable<LessonDto>>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Http status code: {response.StatusCode} message: {message}");
                }
            }
            catch (Exception)
            {
                //Log exception
                throw;
            }
        }
    }
}
