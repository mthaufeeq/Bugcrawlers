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
    
    public partial class ref_ClaimStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ref_ClaimStatus()
        {
            this.trn_Claim = new HashSet<trn_Claim>();
        }
    
        public int ClaimStatusId { get; set; }
        public string ClaimStatusName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trn_Claim> trn_Claim { get; set; }
    }
}
