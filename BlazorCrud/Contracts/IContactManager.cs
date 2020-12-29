using BlazorCrud.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Contracts
{
    interface IContactManager
    {
        Task<int> Insert(ContactRequest request);
        Task<int> SetRead(int Id);
        Task<int> UnreadCount();
        Task<Post> SelectById(int Id);
        Task<List<Post>> ListAll(int skip, int take, string orderBy, string direction, string search);
        Task<List<Post>> ListAllUnread(int skip, int take, string orderBy, string direction, string search);
    }
}
