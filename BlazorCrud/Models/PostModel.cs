using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Models
{
    public class PostModel
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        
        [Required(ErrorMessage = "Title is required")]
        [StringLength(50, ErrorMessage = "Title is too long")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Content is required")]
        [MinLength(3, ErrorMessage = "Content is too short")]
        public string PostContent { get; set; }
    }
}
