using System;
using Microsoft.AspNetCore.Http;
namespace Assignment5.Infrastructure
{
    //why does this have to be a static class?
    public static class UrlExtensions
    {
        public static string PathAndQuery(this HttpRequest request) =>
            request.QueryString.HasValue ? $"{request.Path}{request.QueryString}" : request.Path.ToString();



    }
}