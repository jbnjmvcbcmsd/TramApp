using Flurl;
using Flurl.Http;
using Newtonsoft.Json;
namespace TramApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string json = await GetJson(2169);
            List<string>? times = await GetTime(json, "5");
            string? time = times.FirstOrDefault();
            if(ParseTime(time).Year != 1)
            {
                Console.WriteLine($"Next tram number 5 will leave at {ParseTime(time).TimeOfDay}");

            }
            else
            {
                Console.WriteLine("Go to sleep");
            }
            Console.WriteLine("Push any button");
            Console.ReadKey();
        }

        static async Task<string> GetJson(int stopId)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://ckan2.multimediagdansk.pl/departures?stopId={stopId}";

                string json = await url.GetStringAsync();

                return json;
            }
        }
        static async Task<List<string>>? GetTime(string json, string routeId)
        {
            List<string>? time = new List<string>();
            try
            {
                TramData data = JsonConvert.DeserializeObject<TramData>(json);
                data.departures?.ForEach(x =>
                {
                    if (int.Parse(x.routeId) == int.Parse(routeId))
                    {
                        time.Add(x.theoreticalTime);   
                    }
                });
                return time;
            }
            catch (Exception ex)
            {
                time.Add($"{ex.Message}");
                return time;
            }
            
        }
        static DateTime ParseTime(string data)
        {

            DateTime parsed;

            if (DateTime.TryParseExact(data, "yyyy-MM-ddTHH:mm:ssZ", null, System.Globalization.DateTimeStyles.RoundtripKind, out parsed))
            {
                return parsed.ToLocalTime();
            }
            else
            {
                return new DateTime(1, 1, 1);
            }
        }
    }
}