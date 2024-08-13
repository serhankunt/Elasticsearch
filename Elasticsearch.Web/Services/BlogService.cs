using Elasticsearch.Web.Models;
using Elasticsearch.Web.Repository;
using Elasticsearch.Web.ViewModels;

namespace Elasticsearch.Web.Services;

public class BlogService
{
    private readonly BlogRepository _repository;

    public BlogService(BlogRepository repository)
    {
        _repository = repository;
    }

    public async Task<bool> SaveAsync(BlogCreateViewModel model)
    {
        var newBlog = new Blog
        {
            Title = model.Title,
            UserId = Guid.NewGuid(),
            Content = model.Content,
            Tags = model.Tags.Split(" ")
        };

        var isCreatedBlog = await _repository.SaveAsync(newBlog);

        return isCreatedBlog != null;
    }
}
