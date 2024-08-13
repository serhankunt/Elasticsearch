﻿using Elasticsearch.Web.Services;
using Elasticsearch.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Elasticsearch.Web.Controllers;
public class BlogController : Controller
{
    private BlogService _blogService;

    public BlogController(BlogService blogService)
    {
        _blogService = blogService;
    }

    public IActionResult Save()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Save(BlogCreateViewModel model)
    {
        var isSuccess = await _blogService.SaveAsync(model);
        if (!isSuccess)
        {
            TempData["result"] = "Kayıt başarısız";
            return RedirectToAction(nameof(BlogController.Save));
        }

        TempData["result"] = "Kayıt başarılı";
        return RedirectToAction(nameof(BlogController.Save));
    }
}
