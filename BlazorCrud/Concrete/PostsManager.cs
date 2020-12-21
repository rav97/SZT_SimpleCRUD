using BlazorCrud.Contracts;
using BlazorCrud.Database.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Concrete
{
    public class PostsManager : IPostsManager
    {
        private readonly IDapperManager _dapperManager;

        public PostsManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }

        public Task<int> Count(string search)
        {
            var totalPosts = Task.FromResult(_dapperManager.Get<int>($"select COUNT(*) from Posts WHERE Title like '%{search}%'", null,
                    commandType: CommandType.Text));
            return totalPosts;
        }

        public Task<int> Insert(Post post)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Post> SelectById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Post>> ListAll(int skip, int take, string orderBy, string direction, string search)
        {
            var posts = Task.FromResult(_dapperManager.GetAll<Post>
                ($"SELECT * FROM GET_POSTS({skip}, {take}, '{search}') ORDER BY {orderBy} {direction};", null, commandType: CommandType.Text));
            return posts;
        }

        public Task<int> Update(Post article)
        {
            throw new NotImplementedException();
        }
    }
}
