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
    
    public partial class customer
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<System.DateTime> DTP { get; set; }
        public string NAME { get; set; }
        public string LASTNAME { get; set; }
        public string COMPANY { get; set; }
        public string COMPANYJOB { get; set; }
        public string CUNTRY { get; set; }
        public string STREET { get; set; }
        public string PHON { get; set; }
        public string MOB1 { get; set; }
        public string MOB2 { get; set; }
        public string MAIL { get; set; }
        public string WEB { get; set; }
        public byte[] img { get; set; }
        public string typ_e { get; set; }
        public Nullable<System.Guid> GUID_ACCOUNT { get; set; }
        public System.Guid GUID { get; set; }
        public Nullable<System.Guid> guid_user { get; set; }
    }
}
