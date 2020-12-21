using BlazorCrud.Contracts;
using BlazorCrud.Database.Entities;
using Dapper;
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
            var totalPosts = Task.FromResult(_dapperManager.Get<int>($"SELECT COUNT(*) FROM [Posts] WHERE title LIKE '%{search}%'", null,
                    commandType: CommandType.Text));
            return totalPosts;
        }

        public Task<int> Insert(Post post)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("title", post.Title, DbType.String);
            dbPara.Add("content", post.PostContent, DbType.String);

            var articleId = Task.FromResult(_dapperManager.Insert<int>("[dbo].[INSERT_POST]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return articleId;
        }

        public Task<int> Delete(int Id)
        {
            var deleteArticle = Task.FromResult(_dapperManager.Execute($"DELETE [Posts] WHERE id = {Id}", null,
                    commandType: CommandType.Text));
            return deleteArticle;
        }

        public Task<Post> SelectById(int Id)
        {
            var article = Task.FromResult(_dapperManager.Get<Post>($"SELECT * FROM [Posts] WHERE id = {Id}", null,
                    commandType: CommandType.Text));
            return article;
        }

        public Task<List<Post>> ListAll(int skip, int take, string orderBy, string direction, string search)
        {
            var posts = Task.FromResult(_dapperManager.GetAll<Post>
                ($"SELECT * FROM GET_POSTS({skip}, {take}, '{search}') ORDER BY {orderBy} {direction};", null, commandType: CommandType.Text));
            return posts;
        }

        public Task<int> Update(Post post)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("id", post.Id);
            dbPara.Add("title", post.Title, DbType.String);
            dbPara.Add("content", post.PostContent, DbType.String);

            var updateArticle = Task.FromResult(_dapperManager.Update<int>("[dbo].[UPDATE_POST]",
                                                dbPara,
                                                commandType: CommandType.StoredProcedure));
            return updateArticle;
        }
    }
}
