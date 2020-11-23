using System.Threading.Tasks;
using vid19.Models;
using System.Net.Http;
using System.Text.Json;

namespace vid19.Services
{
    public class Covid19Service
    {
        private readonly HttpClient client = new HttpClient();

        public async Task<Stats> GetWorldStats()
        {
            var worldStatTask = client.GetStreamAsync("https://api.covid19api.com/world/total");
            var worldStats = await JsonSerializer.DeserializeAsync<Stats>(await worldStatTask);
            return worldStats;
        }
    }
}