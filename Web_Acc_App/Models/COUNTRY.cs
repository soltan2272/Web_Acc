//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_Acc_App.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class COUNTRY
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public System.Guid GUID { get; set; }
        public Nullable<System.Guid> guid_user { get; set; }
        public Nullable<System.Guid> PARENT_GUID { get; set; }
    }
}
