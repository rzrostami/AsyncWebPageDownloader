
# Async Web Page Downloader

A C# console application to asynchronously download multiple web pages and save their content locally.

## Features

- Asynchronous downloads using `HttpClient`
- URL validation before download
- Saves each page to `Downloads/` folder


## Project Structure
* `Program.cs`: This file runs the application, takes user input, starts downloads, and handles what happens after downloading.
* `Downloader.cs`: Handles downloading web pages and saving them to your computer.
* `Helpers/UrlValidator.cs`: Provides utility methods for validating URL formats.
* `AsyncWebPageDownloader.Tests/` : Contains integration tests for the whole process.


## Usage

1. Clone the repository:
   ```
   git clone https://github.com/rzrostami/AsyncWebPageDownloader.git
   cd AsyncWebPageDownloader
   ```

2. Run the app.

3. Follow the prompts to enter number of URLs and their addresses.

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

- 
**Author:** Reza Rostami  
