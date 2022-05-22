using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Labb4.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        [Required]
        [MaxLength(30)]
        [MinLength(2)]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerEmail { get; set; }

        // Navigation Properties
        public virtual ICollection<Customer_Book> joinCustomeBook { get; set; }
    }
}
