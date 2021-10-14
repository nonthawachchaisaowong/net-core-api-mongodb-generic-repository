using System;
using System.ComponentModel.DataAnnotations;

namespace MongoBD.GenericRepository.Core.Domains
{
    public class Customer
    {
        public Guid Id { get; set; } = new Guid();
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
    }
}
