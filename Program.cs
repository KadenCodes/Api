using Newtonsoft.Json;
namespace Joke;
class Program
{
    HttpClient client = new();
    public static async Task Main()
    {
        Program program = new();
        await program.MainAsync();
    }

    public async Task MainAsync()
    {
        string response = await client.GetStringAsync("https://official-joke-api.appspot.com/random_joke");
        joke? info = JsonConvert.DeserializeObject<joke>(response);
        Console.WriteLine(info.setup);
        Console.WriteLine(info.punchline);
    }
    class joke
    {
        public string type { get; set; }
        public string setup { get; set; }
        public string punchline { get; set; }
        public int id { get; set; }
    }
}

//steps
/*
step 1.) create a client
step 2.) create a async method
step 3.) parse the response and await the getstringasync 
step 4.) call method in main and print to console.
*/