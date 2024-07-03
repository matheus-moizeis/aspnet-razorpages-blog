﻿using AspNetPro.Blog.Models.Entities;

namespace AspNetPro.Blog;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Post> Posts { get; set; } = new List<Post>();

}
