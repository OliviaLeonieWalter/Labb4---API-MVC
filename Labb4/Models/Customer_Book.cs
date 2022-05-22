using System.ComponentModel.DataAnnotations;

namespace Labb4.Models
{
    public class Customer_Book
    {
        [Key]
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
