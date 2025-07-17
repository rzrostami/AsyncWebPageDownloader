
# Async Web Page Downloader

A C# console application (built with .NET 9) to asynchronously download multiple web pages and save their content locally.

## Features

- Asynchronous downloads using `HttpClient`
- URL validation before download
- Saves each page to `Downloads/` folder


## Requirements

- [.NET 9 SDK](https://dotnet.microsoft.com/) 
- Compatible with Windows, macOS, and Linux

## Project Structure
- `Program.cs`: Entry point; handles user input and triggers downloads.
- `Downloader.cs`: Logic for downloading and saving web pages.
- `Helpers/UrlValidator.cs`: URL validation utilities.
- `AsyncWebPageDownloader.Tests/`: Contains unit and integration tests.

## Build and Run

```bash
git clone https://github.com/rzrostami/AsyncWebPageDownloader.git
cd AsyncWebPageDownloader
dotnet run --project AsyncWebPageDownloader
```

## Usage
Follow the prompts to enter number of URLs and their addresses.

## Sample Output

```
How many web pages do you want to download? 2
Enter URL 1 (e.g., https://google.com): https://google.com
Enter URL 2 (e.g., https://google.com): https://microsoft.com

Starting downloads...
Downloading https://google.com
Download https://google.com finished! Size: 0.13 MB
...
```

## Notes

- All downloaded HTML pages are saved in the `Downloads` directory.
- Only valid HTTP/HTTPS URLs are accepted.

**Author:** Reza Rostami
