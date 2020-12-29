using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Database.Entities
{
    public partial class ContactRequest
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }
    }
}
