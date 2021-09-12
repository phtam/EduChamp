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
    using TN_academic.Areas.Admin.Models;

    public partial class Coupon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Coupon()
        {
            this.Orders = new HashSet<Order>();
        }
        public Coupon(CouponModelForCreate coupon)
        {
            this.CouponID = coupon.CouponID;
            this.CouponCode = coupon.CouponCode;
            this.CouponName = coupon.CouponName;
            this.Description = coupon.Description;
            this.Thumbnail = coupon.Thumbnail;
            this.Rate = coupon.Rate;
            this.Quantity = coupon.Quantity;
            this.Status = coupon.Status;
        }
        public Coupon(CouponModelForEdit coupon)
        {
            this.CouponID = coupon.CouponID;
            this.CouponCode = coupon.CouponCode;
            this.CouponName = coupon.CouponName;
            this.Description = coupon.Description;
            this.Thumbnail = coupon.Thumbnail;
            this.Rate = coupon.Rate;
            this.Quantity = coupon.Quantity;
            this.Status = coupon.Status;
        }

        public int CouponID { get; set; }
        public string CouponCode { get; set; }
        public string CouponName { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<bool> Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}