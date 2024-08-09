﻿using Elasticsearch.API.Models;

namespace Elasticsearch.API.DTOs;

public record ProductUpdateDto(string Id, string Name, decimal Price, int Stock, ProductFeature Feature)
{
}
