using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using News.Models;

namespace News.Services
{
    public interface INewsService
    {
        public Task<NewsResult> GetNews(NewsScope scope);
    }
}
