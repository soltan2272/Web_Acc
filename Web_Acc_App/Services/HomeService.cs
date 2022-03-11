using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_Acc_App.Models;

namespace Web_Acc_App.Services
{
    public class HomeService
    {
        public List<POS_Shieft> GetPOS_Shiefts()
        {
            var pos_shift = new DB_ACCEntities();

            var result = pos_shift.POS_Shieft.ToList();
            return result;
        }

        public List<Sales_Bydate> GetItemSales(int? shiftnum,DateTime? to,DateTime? from,string? groupname)
        {
            var Ites_Sales = new DB_ACCEntities();
            var result = new List<Sales_Bydate>();
            if (shiftnum!=0 )
            {
                result = Ites_Sales.Sales_Bydate.Where(i => i.shift_no == shiftnum).ToList();
            }
            else if(to!=null && from !=null )
            {
                result = Ites_Sales.Sales_Bydate.Where(i => i.DATE<=from && i.DATE>=to).ToList();

            }
            else
            {
               result = Ites_Sales.Sales_Bydate.ToList();
            }

            if (groupname != null)
            {
                result = result.Where(i => i.Group_Name == groupname).ToList(); 
            }
            return result;
           
        }

        public List<POS_Bills_Details> GetPosBillsDetails(int? shiftnum, DateTime? to, DateTime? from)
        {
            var pos_Bills = new DB_ACCEntities();
            var result = pos_Bills.POS_Bills_Details.ToList();
            if (shiftnum != 0)
            {
                result = pos_Bills.POS_Bills_Details.Where(i => i.shift_no == shiftnum).ToList();
            }
            else if (to != null && from != null)
            {
                result = pos_Bills.POS_Bills_Details.Where(i => i.DATE <= from && i.DATE >= to).ToList();

            }
            else
            {
                result = pos_Bills.POS_Bills_Details.ToList();
            }

            
          
            return result;
        }
    }
}