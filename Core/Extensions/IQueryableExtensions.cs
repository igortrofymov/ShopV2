﻿using Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.Extensions
{
    public static class IQueryableExtensions
    {
        public static IQueryable<T> ApplyOrdering <T>(this IQueryable<T> query, IQueryObject queryObj, Dictionary<string, Expression<Func<T, object>>> columnsMap)
        {
            if (String.IsNullOrWhiteSpace(queryObj.SortBy) || !columnsMap.ContainsKey(queryObj.SortBy))
            {
                return query;
            }
            if (queryObj.IsSortAscending)
            {
                return query = query.OrderBy(columnsMap[queryObj.SortBy]);
            }
            else
            {
                return query = query.OrderByDescending(columnsMap[queryObj.SortBy]);
            }
        }
    }
}
