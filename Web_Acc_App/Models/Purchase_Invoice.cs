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
    
    public partial class Purchase_Invoice
    {
        public Nullable<int> NUMBER { get; set; }
        public string NOTE { get; set; }
        public Nullable<System.DateTime> DATE { get; set; }
        public Nullable<double> disc { get; set; }
        public Nullable<double> EXTEA { get; set; }
        public Nullable<double> p_extra { get; set; }
        public Nullable<double> total { get; set; }
        public Nullable<double> p_disc { get; set; }
        public Nullable<double> type_dis { get; set; }
        public Nullable<double> disc_rate { get; set; }
        public string type_pay { get; set; }
        public string delivery_customer { get; set; }
        public string delivery_mobile { get; set; }
        public Nullable<double> knet { get; set; }
        public Nullable<double> cash { get; set; }
        public Nullable<double> VAT { get; set; }
        public Nullable<System.DateTime> time_bill { get; set; }
        public Nullable<double> QTY { get; set; }
        public Nullable<double> PRICE { get; set; }
        public string Expr1 { get; set; }
        public Nullable<double> Expr2 { get; set; }
        public Nullable<double> extra { get; set; }
        public Nullable<System.Guid> guid_store { get; set; }
        public string unit { get; set; }
        public Nullable<double> qty_unit { get; set; }
        public Nullable<int> recpt { get; set; }
        public string barcode { get; set; }
        public Nullable<int> order_n { get; set; }
        public Nullable<double> order_qty { get; set; }
        public Nullable<double> Expr3 { get; set; }
        public Nullable<int> item_id { get; set; }
        public string name { get; set; }
        public int id { get; set; }
        public Nullable<double> Expr4 { get; set; }
        public string Expr5 { get; set; }
        public Nullable<System.Guid> PARENT_GUID { get; set; }
    }
}