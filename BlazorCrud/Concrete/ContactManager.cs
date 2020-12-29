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
    public class ContactManager : IContactManager
    {
        private readonly IDapperManager _dapperManager;

        public ContactManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }

        public Task<int> Insert(ContactRequest request)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("email", request.Email, DbType.String);
            dbPara.Add("message", request.Message, DbType.String);

            var result = Task.FromResult(_dapperManager.Insert<int>("[dbo].[SEND_REQUEST]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return result;
        }

        public Task<List<Post>> ListAll(int skip, int take, string orderBy, string direction, string search)
        {
            throw new NotImplementedException();
        }

        public Task<List<Post>> ListAllUnread(int skip, int take, string orderBy, string direction, string search)
        {
            throw new NotImplementedException();
        }

        public Task<Post> SelectById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<int> SetRead(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UnreadCount()
        {
            throw new NotImplementedException();
        }
    }
}
