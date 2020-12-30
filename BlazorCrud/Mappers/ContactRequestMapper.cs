using BlazorCrud.Database.Entities;
using BlazorCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Mappers
{
    public class ContactRequestMapper
    {
        public static ContactRequest MappData(ContactRequestModel model)
        {
            return new ContactRequest
            {
                Id = model.Id,
                CreateDate = model.CreateDate,
                Email = model.Email,
                Message = model.Message,
                IsRead = model.IsRead
            };
        }

        public static ContactRequestModel MappData(ContactRequest data)
        {
            return new ContactRequestModel
            {
                Id = data.Id,
                CreateDate = data.CreateDate,
                Email = data.Email,
                Message = data.Message,
                IsRead = data.IsRead
            };
        }
    }
}
