using News.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace News.Services
{
    public class NewsService : INewsService, IDisposable
    {
        private bool disposedValue;
        const string UriBase = "https://newsapi.org/v2";
        readonly HttpClient httpClient = new()
        {
            BaseAddress = new(UriBase),
            DefaultRequestHeaders = { { "user-agent", "mauiprojects-news/1.0" } }
        };


        public async Task<NewsResult> GetNews(NewsScope scope)
        {
            NewsResult result;
            string url = ""; // GetUrl(scope);

            try
            {
                result = await httpClient.GetFromJsonAsync<NewsResult>(url);
            }
            catch (Exception ex)
            {
                result = new()
                {
                    Articles = new() { new() { Title = $"HTTP Get failed: {ex.Message}", PublishedAt = DateTime.Now} }
                };
            }
            return result;
        }

        

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            //Dispose(true);
            GC.SuppressFinalize(this);
        }


    }
}
