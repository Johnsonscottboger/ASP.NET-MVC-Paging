using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC分页实例
{
    public class PagingInfo
    {
        //总条目数
        public int TotalItems { get; set; }

        //每页条目总数
        public int ItemsPerPage { get; set; }

        //当前页数
        public int CurrentPage { get; set; }

        //页总数
        public int TotalPages
        {
            get { return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage); }
        }
    }
}