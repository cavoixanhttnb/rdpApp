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
    
    public partial class OfficialStatement
    {
        public string StatementID { get; set; }
        public string StatementType { get; set; }
        public string Content { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ApprovedBy { get; set; }
        public Nullable<System.DateTime> ApprovedDate { get; set; }
        public string Title { get; set; }
        public Nullable<bool> isPublic { get; set; }
    }
}