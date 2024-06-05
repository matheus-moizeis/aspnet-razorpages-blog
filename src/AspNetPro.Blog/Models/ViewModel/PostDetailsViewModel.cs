namespace AspNetPro.Blog.Models.ViewModel;

public record PostDetailsViewModel
{
    public int PostId { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }
    public string? PublishedOn { get; set; }
}
