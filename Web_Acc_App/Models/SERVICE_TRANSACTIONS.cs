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
    
    public partial class SERVICE_TRANSACTIONS
    {
        public int ID { get; set; }
        public string NUMBER { get; set; }
        public string SERVICE_NAME { get; set; }
        public string BARCODE { get; set; }
        public Nullable<System.DateTime> DATE { get; set; }
        public string REF_NUMBER { get; set; }
        public string SHIFT { get; set; }
        public Nullable<System.Guid> PARENT_GUID { get; set; }
        public string User_Name { get; set; }
        public Nullable<double> PRICE { get; set; }
        public Nullable<int> is_printed { get; set; }
    }
}
