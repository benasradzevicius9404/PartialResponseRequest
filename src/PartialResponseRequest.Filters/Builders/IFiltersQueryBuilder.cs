﻿using PartialResponseRequest.Filters.TokenReaders.Tokens;
using System.Collections.Generic;

namespace PartialResponseRequest.Filters.Builders
{
    public interface IFiltersQueryBuilder
    {
        List<FilterToken> Build();
    }
}
