﻿using Elastic.Clients.Elasticsearch;
using Elastic.Clients.Elasticsearch.QueryDsl;
using Elasticsearch.API.Models.ECommerceModel;
using System.Collections.Immutable;

namespace Elasticsearch.API.Repository;

public class ECommerceRepository
{
    private readonly ElasticsearchClient _client;
    private const string indexName = "kibana_sample_data_ecommerce";

    public ECommerceRepository(ElasticsearchClient client)
    {
        _client = client;
    }

    public async Task<ImmutableList<ECommerce>> TermQuery(string customerFirstName)
    {
        //1.yol
        //var result = await _client.SearchAsync<ECommerce>(s => s.Index(indexName).Query(q => q.Term(t => t.Field("customer_first_name.keyword").Value(customerFirstName))));

        //2.yol
        //var result = await _client.SearchAsync<ECommerce>(s => s.Index(indexName)
        //.Query(q => q.Term(t => t.CustomerFirstName.Suffix("keyword"), customerFirstName)));

        //3.yol 
        var termQuery = new TermQuery("customer_first_name.keyword") { Value = customerFirstName, CaseInsensitive = true };
        var result = await _client.SearchAsync<ECommerce>(s => s.Index(indexName).Query(termQuery));


        foreach (var hit in result.Hits)
        {
            hit.Source!.Id = hit.Id;
        }
        return result.Documents.ToImmutableList();
    }

    public async Task<ImmutableList<ECommerce>> TermsQueryAsync(List<string> customerFirstNameList)
    {
        List<FieldValue> terms = new List<FieldValue>();

        customerFirstNameList.ForEach(x =>
        {
            terms.Add(x);
        });

        //1.yol
        var termsQuery = new TermsQuery()
        {
            Field = "customer_first_name.keyword",
            Terms = new TermsQueryField(terms.AsReadOnly())
        };

        var result = await _client.SearchAsync<ECommerce>(s => s.Index(indexName).Query(termsQuery));

        //2.yol ama hata var
        //var result = await _client.SearchAsync<ECommerce>(s => s.Index(indexName)
        //.Query(q => q
        //.Term(t => t
        //.Field(f => f.CustomerFirstName
        //.Suffix("keyword"))
        //.Terms(new TermsQueryField(terms.AsReadOnly())))));



        foreach (var hit in result.Hits) hit.Source!.Id = hit.Id;
        return result.Documents.ToImmutableList();
    }

    public async Task<ImmutableList<ECommerce>> PrefixQueryAsync(string CustomerFullName)
    {
        var result = await _client
            .SearchAsync<ECommerce>(s => s.Index(indexName)
            .Query(q => q
            .Prefix(p => p
            .Field(f => f.CustomerFullName
            .Suffix("keyword"))
            .Value(CustomerFullName))));

        return result.Documents.ToImmutableList();
    }

    public async Task<ImmutableList<ECommerce>> RangeQueryAsync(double FromPrice, double ToPrice)
    {
        var result = await _client
            .SearchAsync<ECommerce>(s => s.Index(indexName)
            .Query(q => q
            .Range(r => r
            .NumberRange(nr => nr
            .Field(f => f.TaxulTotalPrice)
            .Gt(FromPrice)
            .Lt(ToPrice)))));

        return result.Documents.ToImmutableList();
    }

    public async Task<ImmutableList<ECommerce>> MatchAllQueryAsync()
    {
        var result = await _client.SearchAsync<ECommerce>(s => s.Index(indexName)
        .Size(100)
        .Query(q => q.MatchAll()));

        foreach (var hit in result.Hits) hit.Source.Id = hit.Id;

        return result.Documents.ToImmutableList();

    }

    public async Task<ImmutableList<ECommerce>> PaginationQueryAsync(int page, int pageSize)
    {
        var pageFrom = (page - 1) * pageSize;
        var result = await _client.SearchAsync<ECommerce>(s => s.Index(indexName)
        .Size(pageSize)
        .From(pageFrom)
        .Query(q => q.MatchAll()));

        foreach (var hit in result.Hits) hit.Source.Id = hit.Id;

        return result.Documents.ToImmutableList();

    }

    public async Task<ImmutableList<ECommerce>> WildCardQuery(string customerFullName)
    {

        var result = await _client.SearchAsync<ECommerce>(s => s.Index(indexName)
            .Query(q => q.Wildcard(w => w.Field(f => f.CustomerFullName.Suffix("keyword")).Wildcard(customerFullName))));

        foreach (var hit in result.Hits) hit.Source.Id = hit.Id;

        return result.Documents.ToImmutableList();

    }

    public async Task<ImmutableList<ECommerce>> FuzzyQueryAsync(string customerName)
    {

        var result = await _client.SearchAsync<ECommerce>(s => s.Index(indexName)
            .Query(q =>
                q.Fuzzy(u =>
                u.Field(f =>
                f.CustomerFirstName
                .Suffix("keyword"))
                .Value(customerName)
                .Fuzziness(new Fuzziness(1)))).Sort(sort => sort.Field(f => f.TaxulTotalPrice, new FieldSort() { Order = SortOrder.Desc })));

        foreach (var hit in result.Hits) hit.Source.Id = hit.Id;

        return result.Documents.ToImmutableList();

    }
    public async Task<ImmutableList<ECommerce>> MatchQueryFullTextAsync(string categoryName)
    {
        var result = await _client.SearchAsync<ECommerce>(s =>
            s.Index(indexName)
            .Size(1000).Query(q =>
            q.Match(m => m.Field(f => f.Category)
            .Query(categoryName)
            .Operator(Operator.And))));

        foreach (var hit in result.Hits)
        {
            hit.Source.Id = hit.Id;
        }
        return result.Documents.ToImmutableList();

    }

    public async Task<ImmutableList<ECommerce>> MultiMatchQueryFullTextAsync(string name)
    {
        var result = await _client.SearchAsync<ECommerce>(s =>
        s.Index(indexName)
        .Size(1000)
        .Query(q =>
        q.MultiMatch(mm =>
        mm.Fields(new Field("customer_first_name")
        .And(new Field("customer_last_name"))
        .And(new Field("customer_full_name")))
        .Query(name))));

        foreach (var hit in result.Hits)
        {
            hit.Source.Id = hit.Id;
        }
        return result.Documents.ToImmutableList();

    }

    public async Task<ImmutableList<ECommerce>> CompoundQueryExampleOneAsync(string cityName, double taxFulTotalPrice, string categoryName, string manufacturer)
    {
        var result = await _client.SearchAsync<ECommerce>(s => s.Index(indexName)
        .Size(1000)
        .Query(q =>
            q.Bool(b =>
                b.Must(m =>
                    m.Term(t =>
                        t.Field("geoip.city_name")
                        .Value(cityName)))
                .MustNot(mn =>
                mn.Range(r =>
                    r.NumberRange(nr =>
                        nr.Field(f =>
                            f.TaxulTotalPrice).Lte(taxFulTotalPrice))))
                .Should(s => s.Term(t => t.Field(f => f.Category.Suffix("keyword")).Value("")))
                .Filter(f => f.Term(t => t.Field("manufacturer.keyword").Value(manufacturer))))));

        foreach (var hit in result.Hits)
        {
            hit.Source.Id = hit.Id;
        }
        return result.Documents.ToImmutableList();

    }
}
