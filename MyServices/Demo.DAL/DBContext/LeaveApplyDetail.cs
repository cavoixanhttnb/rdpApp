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
    
    public partial class LeaveApplyDetail
    {
        public long id { get; set; }
        public string ApplyID { get; set; }
        public string ApplyDetailType { get; set; }
        public string ActionBy { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
