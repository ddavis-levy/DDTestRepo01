//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DELETE_ERD
{
    using System;
    using System.Collections.Generic;
    
    public partial class SUITE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SUITE()
        {
            this.CUSTOMER_CREDIT_CARD_SUITE = new HashSet<CUSTOMER_CREDIT_CARD_SUITE>();
            this.CUSTOMER_SUITE = new HashSet<CUSTOMER_SUITE>();
        }
    
        public int SUITE_ID { get; set; }
        public int PANTRY_ID { get; set; }
        public Nullable<int> SUITE_TYPE_ID { get; set; }
        public string SUITE_NUMBER { get; set; }
        public int CAPACITY { get; set; }
        public int MAX_CHAFFERS { get; set; }
        public string DESCRIPTION { get; set; }
        public System.DateTime EFFECTIVE_START_DATE { get; set; }
        public Nullable<System.DateTime> EFFECTIVE_END_DATE { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public int CREATED_BY { get; set; }
        public System.DateTime LAST_UPDATED_DATE { get; set; }
        public int LAST_UPDATED_BY { get; set; }
        public string ATTRIBUTE1 { get; set; }
        public string ATTRIBUTE2 { get; set; }
        public string ATTRIBUTE3 { get; set; }
        public string ATTRIBUTE4 { get; set; }
        public string ATTRIBUTE5 { get; set; }
        public string ATTRIBUTE6 { get; set; }
        public string ATTRIBUTE7 { get; set; }
        public string ATTRIBUTE8 { get; set; }
        public string ATTRIBUTE9 { get; set; }
        public string ATTRIBUTE10 { get; set; }
        public string ATTRIBUTE11 { get; set; }
        public string ATTRIBUTE12 { get; set; }
        public string ATTRIBUTE13 { get; set; }
        public string ATTRIBUTE14 { get; set; }
        public string ATTRIBUTE15 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CUSTOMER_CREDIT_CARD_SUITE> CUSTOMER_CREDIT_CARD_SUITE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CUSTOMER_SUITE> CUSTOMER_SUITE { get; set; }
        public virtual SUITE_TYPE SUITE_TYPE { get; set; }
    }
}
