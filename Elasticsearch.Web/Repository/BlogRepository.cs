using Elastic.Clients.Elasticsearch;
using Elastic.Clients.Elasticsearch.QueryDsl;
using Elasticsearch.Web.Models;

namespace Elasticsearch.Web.Repository;

public class BlogRepository
{
    private readonly ElasticsearchClient _elasticsearchClient;
    private const string indexName = "blog";
    public BlogRepository(ElasticsearchClient elasticsearchClient)
    {
        _elasticsearchClient = elasticsearchClient;
    }

    public async Task<Blog?> SaveAsync(Blog newBlog)
    {
        newBlog.Created = DateTime.Now;

        var response = await _elasticsearchClient.IndexAsync(newBlog, x => x.Index(indexName));

        if (!response.IsValidResponse) return null;

        newBlog.Id = response.Id;

        return newBlog;


    }

    public async Task<List<Blog>> SearchAsync(string searchText)
    {
        List<Action<QueryDescriptor<Blog>>> ListQuery = new();

        // Eğer arama metni boşsa tüm dökümanları getir.
        if (string.IsNullOrEmpty(searchText))
        {
            ListQuery.Add(q => q.MatchAll());
        }
        else
        {
            // Title alanına göre match sorgusu
            ListQuery.Add(q => q.Match(m => m.Field(f => f.Title).Query(searchText)));

            // Content alanına göre match sorgusu
            ListQuery.Add(q => q.Match(m => m.Field(f => f.Content).Query(searchText)));

            // Title alanına göre match bool prefix sorgusu
            ListQuery.Add(q => q.MatchBoolPrefix(m => m.Field(f => f.Title).Query(searchText)));

            // Content alanına göre match bool prefix sorgusu
            ListQuery.Add(q => q.MatchBoolPrefix(m => m.Field(f => f.Content).Query(searchText)));
        }

        // Sorguları Bool query içinde 'should' olarak kullan.
        var result = await _elasticsearchClient.SearchAsync<Blog>(s => s.Index(indexName)
            .Size(1000)
            .Query(q =>
                q.Bool(b =>
                    b.Should(ListQuery.ToArray())
                )
            )
        );

        // ID'leri sonuçlara ekle
        foreach (var hit in result.Hits) hit.Source.Id = hit.Id;
        return result.Documents.ToList();
    }


    //public async Task<List<Blog>> SearchAsync(string searchText)
    //{
    //    List<Action<QueryDescriptor<Blog>>> ListQuery = new();


    //    Action<QueryDescriptor<Blog>> matchAll = (q) => q.MatchAll();

    //    Action<QueryDescriptor<Blog>> matchContent = (q) => q.Match(m => m.Field(f => f.Content).Query(searchText));

    //    Action<QueryDescriptor<Blog>> titleMatchBoolPrefix = (q) => q.MatchBoolPrefix(m => m.Field(f => f.Content).Query(searchText));

    //    if (string.IsNullOrEmpty(searchText))
    //    {
    //        ListQuery.Add(matchAll);
    //    }
    //    else
    //    {
    //        ListQuery.Add(matchContent);
    //        ListQuery.Add(matchContent);
    //    }

    //    var result = await _elasticsearchClient.SearchAsync<Blog>(s => s.Index(indexName)
    //    .Size(1000)
    //    .Query(q =>
    //        q.Bool(b =>
    //            b.Should(s =>
    //                s.Match(m =>
    //                    m.Field(f =>
    //                        f.Content)
    //    .Query(searchText))
    //    .MatchBoolPrefix(m =>
    //        m.Field(f => f.Title)
    //    .Query(searchText))))));

    //    foreach (var hit in result.Hits) hit.Source.Id = hit.Id;
    //    return result.Documents.ToList();
    //}
}
