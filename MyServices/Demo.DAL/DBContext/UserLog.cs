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
    
    public partial class UserLog
    {
        public long Id { get; set; }
        public string UserID { get; set; }
        public string Action { get; set; }
        public string Objects { get; set; }
        public string ContentBefore { get; set; }
        public string ContentAfter { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    }
}
