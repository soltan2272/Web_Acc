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
    
    public partial class check_car
    {
        public int id { get; set; }
        public Nullable<System.DateTime> check_date { get; set; }
        public string customer_name { get; set; }
        public string customer_phone { get; set; }
        public string cat_type { get; set; }
        public string car_no { get; set; }
        public string sheseh_no { get; set; }
        public string km_count { get; set; }
        public string model_no { get; set; }
        public string Computer_check { get; set; }
        public string geer_check { get; set; }
        public string bakaks_or_exat { get; set; }
        public string shaseh_check { get; set; }
        public string front_check { get; set; }
        public string body_check { get; set; }
        public string double_geer { get; set; }
        public string front_bakaks { get; set; }
        public Nullable<double> total { get; set; }
        public Nullable<double> cash { get; set; }
        public Nullable<double> knet { get; set; }
        public Nullable<double> remain { get; set; }
        public Nullable<System.Guid> user { get; set; }
    }
}