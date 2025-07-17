using Xunit;

namespace AsyncWebPageDownloader.Tests
{
    public class DownloaderIntegrationTests
    {
        [Fact]
        public async Task DownloadAsync_ShouldDownloadAndSaveHtmlFile()
        {
            const string testUrl = "https://example.com";
            var httpClient = new HttpClient();
            var downloader = new Downloader(httpClient);

            await downloader.DownloadAsync(testUrl);

            const string expectedFileName = "example.com.html";
            var expectedFilePath = Path.Combine("Downloads", expectedFileName);

            Assert.True(File.Exists(expectedFilePath), $"Expected file '{expectedFilePath}' does not exist.");

            var fileContent = await File.ReadAllTextAsync(expectedFilePath);
            Assert.Contains("Example Domain", fileContent);

            File.Delete(expectedFilePath);
        }
    }
}
