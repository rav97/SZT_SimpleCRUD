using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Models
{
    public class ContactRequestModel
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        
        [Required(ErrorMessage = "Email address is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Wrong email format")]
        public string Email { get; set; }

        [Required]
        [MinLength(10, ErrorMessage = "Message is too short")]
        public string Message { get; set; }
        public bool IsRead { get; set; }
    }
}
