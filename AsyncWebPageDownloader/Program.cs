using AsyncWebPageDownloader;
using AsyncWebPageDownloader.Helpers;

var httpClient = new HttpClient();
var downloader = new Downloader(httpClient);
var urls = new List<string>();

int numberOfUrls;

while (true)
{
    Console.Write("How many web pages do you want to download? ");


   if (int.TryParse(Console.ReadLine(), out numberOfUrls) && numberOfUrls > 0)
        break;

    Console.WriteLine("Please enter a valid number.");
}

for (var i = 1; i <= numberOfUrls; i++)
{
    Console.Write($"Enter URL {i} (e.g., https://google.com): ");
    var input = Console.ReadLine()?.Trim();

    if (!UrlValidator.IsValid(input))
    {
        Console.WriteLine("Invalid URL. Please try again.");
        i--;
        continue;
    }

    if (urls.Any(x => x.Equals(input, StringComparison.InvariantCultureIgnoreCase)))
    {
        Console.WriteLine("The URL already exists. Please enter a new URL.");
        i--;
        continue;
    }

    urls.Add(input!);
}

Console.WriteLine("Starting downloads...");

var tasks = urls.Select(url => downloader.DownloadAsync(url));
await Task.WhenAll(tasks);

Console.WriteLine("All downloads completed!");
Console.WriteLine("\nPlease enter a key to exit.");

Console.ReadKey();

httpClient.Dispose();