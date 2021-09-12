//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TN_academic.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Contact
    {
        [DisplayName("Contact ID")]
        public int ContactID { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a valid contact name!")]
        [StringLength(maximumLength: 100, MinimumLength = 5, ErrorMessage = "The contact name must be between 5 and 100 characters long.")]
        [DisplayName("Contact name")]
        public string ContactName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a valid phone number!")]
        [StringLength(maximumLength: 20, MinimumLength = 3, ErrorMessage = "Phone number must be between 3 and 20 characters long.")]
        [RegularExpression(@"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$", ErrorMessage = "The phone number is incorrect format. Try again, please!")]
        public string Phone { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a valid email!")]
        [StringLength(maximumLength: 150, MinimumLength = 5, ErrorMessage = "The email must be between 6 and 150 characters long.")]

        public string Email { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a valid fax!")]
        [StringLength(maximumLength: 50, MinimumLength = 5, ErrorMessage = "The fax must be between 5 and 50 characters long.")]
        [DisplayName("Fax")]
        public string Fax { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a valid address!")]
        public string Address { get; set; }
    }
}
