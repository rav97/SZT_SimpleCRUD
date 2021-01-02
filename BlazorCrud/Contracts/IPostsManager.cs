using BlazorCrud.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Contracts
{
    public interface IPostsManager
    {
        Task<int> Insert(Post post);
        Task<int> Delete(int Id);
        Task<int> Count(string search);
        Task<int> Update(Post post);
        Task<Post> SelectById(int Id);
        Task<List<Post>> ListPage(string search, string orderBy, string direction, int pageSize, int pageNo);
    }
}
