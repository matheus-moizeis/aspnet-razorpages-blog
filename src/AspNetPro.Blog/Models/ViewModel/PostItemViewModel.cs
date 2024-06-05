namespace AspNetPro.Blog.Models.ViewModel;

public record PostItemViewModel
{
    public int PostId { get; set; }
    public string? Title { get; set; }
    public string? Summary { get; set; }
    public string? PublishedOn { get; set; }
}
