//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HumberShores.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OPPORTUNITY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPPORTUNITY()
        {
            this.VOLUNTEERs = new HashSet<VOLUNTEER>();
        }
    
        public int OPPORTUNITY_ID { get; set; }
        public string OPPORTUNITY_TITLE { get; set; }
        public string OPPORTUNITY_DESC { get; set; }
        public int DEPT_ID { get; set; }
        public System.DateTime START_DATE { get; set; }
        public string CONTACT_FN { get; set; }
        public string CONTACT_LN { get; set; }
        public string CONTACT_EMAIL { get; set; }
    
        public virtual department department { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VOLUNTEER> VOLUNTEERs { get; set; }
    }
}
