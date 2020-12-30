using BlazorCrud.Database.Entities;
using BlazorCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Mappers
{
    public class PostMapper
    {
        public static Post MappData(PostModel model)
        {
            return new Post
            {
                Id = model.Id,
                CreateDate = model.CreateDate,
                Title = model.Title,
                PostContent = model.PostContent
            };
        }

        public static PostModel MappData(Post data)
        {
            return new PostModel
            {
                Id = data.Id,
                CreateDate = data.CreateDate,
                Title = data.Title,
                PostContent = data.PostContent
            };
        }
    }
}
