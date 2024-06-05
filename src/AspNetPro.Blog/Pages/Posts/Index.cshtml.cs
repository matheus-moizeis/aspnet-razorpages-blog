using AspNetPro.Blog.Infrastructure.Data;
using AspNetPro.Blog.Models.ViewModel;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetPro.Blog.Pages.Posts;

public class IndexModel(BlogContext blogContext) : PageModel
{
    public IList<PostItemViewModel> Posts { get; set; }
    public void OnGet()
    {
        Posts = blogContext.Posts
            .OrderByDescending(p => p.PublishedOn)
            .Select(p => new PostItemViewModel
            {
                PostId = p.Id,
                Title = p.Title,
                Summary = p.Summary,
                PublishedOn = p.PublishedOn.Value.ToShortDateString(),
            })
            .ToList();
    }
}
