using System.Text.RegularExpressions;
using System.Net;

public static class InputSanitizer
{
    public static string SanitizeUsername(string input)
    {
        return Regex.Replace(input ?? "", @"[^a-zA-Z0-9_]", "");
    }

    public static bool IsValidEmail(string email)
    {
        return Regex.IsMatch(email ?? "", @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
    }

    public static string EncodeForHtml(string input)
    {
        return WebUtility.HtmlEncode(input);
    }
}