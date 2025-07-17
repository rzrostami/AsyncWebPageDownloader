namespace AsyncWebPageDownloader.Helpers;

public static class UrlValidator
{
    public static bool IsValid(string? url)
    {
        return !string.IsNullOrWhiteSpace(url) && Uri.IsWellFormedUriString(url.Trim(), UriKind.Absolute);
    }
}