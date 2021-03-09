using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HPlusSport.Ecommerce.Data.Entities
{
    public partial class Customer
    {
        public Customer()
        {
            Carts = new HashSet<Cart>();
            Users = new HashSet<User>();
        }

        public int CustomerId { get; set; }

        [Required]
        [StringLength(100)]
        public string CustomerName { get; set; }

        [Required]
        [StringLength(100)]
        public string Address1 { get; set; }

        [Required]
        [StringLength(100)]
        public string Address2 { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(100)]
        public string Region { get; set; }

        [Required]
        [StringLength(5)]
        public string PostalCode { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}