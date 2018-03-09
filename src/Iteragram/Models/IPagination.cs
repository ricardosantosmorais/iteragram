using System;
using System.Collections.Generic;

namespace Iteragram.Models
{
    public interface IPagination<T>
    {
        Pagination Pagination { get; set; }
        List<T> Data { get; set; }
    }
}
