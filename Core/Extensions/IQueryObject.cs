using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extensions
{
    public interface IQueryObject
    {
         string SortBy { get; set; }
         bool IsSortAscending { get; set; }
    }
}
