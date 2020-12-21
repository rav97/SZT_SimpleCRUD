using System;
using System.Collections.Generic;

#nullable disable

namespace BlazorCrud.Database.Entities
{
    public partial class Post
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Title { get; set; }
        public string PostContent { get; set; }
    }
}
