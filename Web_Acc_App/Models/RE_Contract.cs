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
    
    public partial class RE_Contract
    {
        public int id { get; set; }
        public Nullable<int> Contract_No { get; set; }
        public Nullable<System.DateTime> Contract_Date { get; set; }
        public string Guest_Name { get; set; }
        public Nullable<int> C_ID { get; set; }
        public string Pass_NO { get; set; }
        public string Nationality { get; set; }
        public string Mobile { get; set; }
        public string Flat_No { get; set; }
        public string Floor_No { get; set; }
        public Nullable<System.DateTime> End_Current_Rent { get; set; }
        public Nullable<int> Rent_Period { get; set; }
        public string Flat_Status { get; set; }
        public Nullable<System.DateTime> Start_Rent_Date { get; set; }
        public Nullable<System.DateTime> End_Rent_Date { get; set; }
        public Nullable<double> Day_Price { get; set; }
        public Nullable<double> Total_Amount { get; set; }
        public Nullable<double> Payment_Cash { get; set; }
        public Nullable<double> Payment_VISA { get; set; }
        public Nullable<double> Total_Payment { get; set; }
        public string Contract_Status { get; set; }
    }
}