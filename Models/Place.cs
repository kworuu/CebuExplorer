namespace MidtermProj.Models;

public record Place(
    string Id,
    string Name,
    string Category,      // Heritage | Nature | Food | Shopping
    string Area,
    string Summary,
    string Description,
    string BestTime,
    string Entrance,
    string[] Tips,
    string Keywords,
    string? Image = null)
{
    public string Cover => Image ?? PlaceImages.ForCategory(Category);
}