using LogBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogBook.Services
{
    public interface ILogBookService
    {
        public Task<List<LogPost>> GetPostsAsync();
    }
}
