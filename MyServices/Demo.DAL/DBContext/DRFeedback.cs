//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo.DAL.DBContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class DRFeedback
    {
        public long id { get; set; }
        public string FBContent { get; set; }
        public Nullable<bool> RequiredHigher { get; set; }
        public string HigherUID { get; set; }
        public Nullable<long> RefPrevious { get; set; }
        public Nullable<long> RefDRid { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<bool> MarkComplete { get; set; }
        public string MarkBy { get; set; }
    }
}
