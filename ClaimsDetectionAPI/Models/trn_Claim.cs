//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClaimsDetectionAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class trn_Claim
    {
        public int ClaimId { get; set; }
        public int CustomerId { get; set; }
        public int PolicyID { get; set; }
        public string ClaimRefernceNumber { get; set; }
        public System.DateTime ClaimDate { get; set; }
        public string ClaimDetails { get; set; }
        public int ClaimStatusId { get; set; }
    
        public virtual ref_ClaimStatus ref_ClaimStatus { get; set; }
        public virtual ref_Customer ref_Customer { get; set; }
        public virtual trn_Policy trn_Policy { get; set; }
    }
}