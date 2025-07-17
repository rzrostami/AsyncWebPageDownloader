using System.Text;

namespace AsyncWebPageDownloader;

public class Downloader(HttpClient httpClient)
{
    public async Task DownloadAsync(string url)
    {
        try
        {
            Console.WriteLine($"Downloading {url}");

            var response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var bytes = Encoding.UTF8.GetByteCount(content) / (1024m * 1024m);

            Console.WriteLine($"Download {url} finished! Size: {bytes:F2} MB");

            var fileName = GetSafeFilename(url);
            Directory.CreateDirectory("Downloads");
            await File.WriteAllTextAsync(Path.Combine("Downloads", fileName), content);
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"HTTP error while downloading {url}: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error for {url}: {ex.Message}");
        }
    }

    private static string GetSafeFilename(string url)
    {
        var invalids = Path.GetInvalidFileNameChars();
        var name = url.Replace("https://", "").Replace("http://", "").Replace("/", "_");
        return string.Join("_", name.Split(invalids, StringSplitOptions.RemoveEmptyEntries)) + ".html";
    }
}