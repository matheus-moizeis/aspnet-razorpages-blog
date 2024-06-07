﻿using System.ComponentModel.DataAnnotations;

namespace AspNetPro.Blog.Models.FormModel;

public record CommentFormModel
{
    public int PostId { get; set; }
    
    [Required]
    [StringLength(100)]
    public string? Author { get; set; }
    
    [Required]
    [StringLength(1000)]
    public string? Content { get; set; }
}
