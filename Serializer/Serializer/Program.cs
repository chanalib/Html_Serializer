using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    public static async Task<string> Load(string url)
    {
        HttpClient client = new HttpClient();
        var response = await client.GetAsync(url);

        // בדוק אם הבקשה הצליחה
        if (response.IsSuccessStatusCode)
        {
            var html = await response.Content.ReadAsStringAsync();
            return html;
        }
        else
        {
            return $"Error: {response.StatusCode}";
        }
    }

    static async Task Main(string[] args)
    {
        string url = "https://www.10dakot.co.il/recipe"; // הכנס את ה-URL שלך כאן
        string content = await Load(url);
        Console.WriteLine(content); // הדפס את התוכן
    }
}
