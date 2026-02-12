namespace BuberDinner.Contracts.Menus;

public class MenuResponse
{
    public string Id { get; init; } = null!;
    public string Name { get; init; } = null!;
    public string Description { get; init; } = null!;
    public float? AverageRating { get; init; } = null!;
    public List<MenuSectionResponse> Sections { get; init; } = null!;
    public string HostId { get; init; } = null!;
    public List<string> DinnerIds { get; init; } = null!;
    public List<string> MenuReviewIds { get; init; } = null!;
    public DateTime CreatedDateTime { get; init; }
    public DateTime UpdatedDateTime { get; init; }
}

public record MenuSectionResponse(
    string Id,
    string Name,
    string Description,
    List<MenuItemResponse> Items);

public record MenuItemResponse(
    string Id,
    string Name,
    string Description);