using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Labb4.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        [Required]
        public string BookTitle { get; set; }
        [Required]
        public string Author { get; set; }
        public int Pages { get; set; }
        public string Language { get; set; }
        public DateTime ReleaseDate { get; set; }
        [Required]
        [StringLength(13)]
        public string ISBN { get; set; }
        public string CoverImageUrl { get; set; }
        [Required]
        public string BookDescription { get; set; }
        public int BookShelfNumber { get; set; }
        public DateTime BorrowingStartDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public bool isBorrowed { get; set; }

        // Navigation Properties
        public virtual ICollection<Customer_Book> joinCustomeBook { get; set; }

    }
}
