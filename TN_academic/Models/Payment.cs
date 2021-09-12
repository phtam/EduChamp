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

    public partial class Payment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Payment()
        {
            this.Orders = new HashSet<Order>();
        }

        [DisplayName("Payment ID")]
        public int PaymentID { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a valid payment name!")]
        [StringLength(maximumLength: 100, MinimumLength = 5, ErrorMessage = "The payment name must be between 5 and 100 characters long.")]
        [DisplayName("Payment name")]
        public string PaymentName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
