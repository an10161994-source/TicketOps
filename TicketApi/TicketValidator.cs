
namespace TicketApi;

public static class TicketValidator
{
    public static bool IsValidTitle(string? title)
    {
        return !string.IsNullOrWhiteSpace(title)
            && title.Trim().Length >= 5
            && title.Trim().Length <= 100;
    }
}
