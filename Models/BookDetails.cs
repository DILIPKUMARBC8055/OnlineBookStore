using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OnlineBookStore.Models
{
    public class BookDetails
    {
        [Key]
        [Required]
        public int BookId { get; set; }
        public string BookType { get; set; }
    }
}