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
    
    public partial class CUSTOMER_PREFERENCE
    {
        public int CUSTOMER_PREFERENCE_ID { get; set; }
        public int CUSTOMER_ID { get; set; }
        public int LOCATION_ID { get; set; }
        public int CUSTOMER_PREFERENCE_LIST_ID { get; set; }
        public string VALUE { get; set; }
        public Nullable<int> BILLING_TYPE_ID { get; set; }
        public System.DateTime EFFECTIVE_START_DATE { get; set; }
        public Nullable<System.DateTime> EFFECTIVE_END_DATE { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public int CREATED_BY { get; set; }
        public System.DateTime LAST_UPDATED_DATE { get; set; }
        public int LAST_UPDATED_BY { get; set; }
    
        public virtual CUSTOMER CUSTOMER { get; set; }
        public virtual CUSTOMER_PREFERENCE_LIST CUSTOMER_PREFERENCE_LIST { get; set; }
    }
}
