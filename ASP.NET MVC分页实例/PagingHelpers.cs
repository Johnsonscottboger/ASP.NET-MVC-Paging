using ASP.NET_MVC分页实例;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC分页实例
{
    public static class PagingHelpers
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html,PagingInfo pagingInfo,Func<int,string> pageUrl)
        {
            StringBuilder result = new StringBuilder();
            result.Append("<ul>");

            if(pagingInfo.CurrentPage>1)
            {
                //建立首页分页链接
                result.Append("<li>");
                result.Append("<a href='");
                result.Append(pageUrl(1));
                result.Append("'>首页</a>");
                result.Append("</li>");
                //建立上一页分页链接
                result.Append("<li>");
                result.Append("<a href='");
                result.Append(pageUrl(pagingInfo.CurrentPage - 1));
                result.Append("'>上一页</a>");
                result.Append("</li>");
            }

            for(int i=1;i<=pagingInfo.TotalPages;i++)
            {
                if(i<=2||i>=pagingInfo.CurrentPage-3&&i<=pagingInfo.CurrentPage+3||i>=pagingInfo.TotalPages-1)
                {
                    CreatePageLink(pagingInfo, pageUrl, result, i);
                }
                else if(result[result.Length-1]!='.')
                {
                    result.Append("...");
                }
            }

            if(pagingInfo.CurrentPage<pagingInfo.TotalPages)
            {
                //建立下一页分页链接
                result.Append("<li>");
                result.Append("<a href='");
                result.Append(pageUrl(pagingInfo.CurrentPage + 1));
                result.Append("'>下一页</a>");
                result.Append("</li>");
                //建立尾页分页链接
                result.Append("<li>");
                result.Append("<a href='");
                result.Append(pageUrl(pagingInfo.TotalPages));
                result.Append("'>尾页</a>");
                result.Append("</li>");
            }
            result.Append("</ul>");
            return MvcHtmlString.Create(result.ToString());
        }

        private static void CreatePageLink(PagingInfo pagingInfo,Func<int,string> pageUrl,StringBuilder result,int i)
        {
            if(i==pagingInfo.CurrentPage)
            {
                result.Append("<li class='current'>");
            }
            else
            {
                result.Append("<li>");
            }
            result.Append("<a href='");
            result.Append(pageUrl(i));
            result.Append("'>");
            result.Append(i);
            result.Append("</a>");
            result.Append("</li>");
        }
    }
}