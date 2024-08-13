﻿using System.ComponentModel.DataAnnotations;

namespace Elasticsearch.Web.ViewModels;

public class BlogCreateViewModel
{
    [Display(Name = "Blog Title")]
    public string Title { get; set; } = null!;
    [Display(Name = "Blog Content")]
    public string Content { get; set; } = null!;
    [Display(Name = "Blog Tags")]
    public string Tags { get; set; } = null!;
}
