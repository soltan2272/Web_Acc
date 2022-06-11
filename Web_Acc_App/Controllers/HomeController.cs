using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Acc_App.Models;
using Web_Acc_App.Services;

namespace Web_Acc_App.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        HomeService service = new HomeService();
        public ActionResult Index()
        {
            var pos_shit = service.GetPOS_Shiefts();

            
            return View(pos_shit);
        }
        
        [Route("ItemDetails")]
        public ActionResult ItemDetails(string? shiftnum , string? to ,string? from , string? groupname)
        {
            int shftnum = 0;
            DateTime? tosearch =null;
            DateTime? fromsearch = null;
            string? grpname = null;
            
            var ItemSales = new List<Sales_Bydate>();

            if (shiftnum!=null && groupname != null)
            { 
                shftnum = Int32.Parse(shiftnum);
                
            }

            if (to != null && from!=null && groupname != null)
            {
                tosearch = DateTime.Parse(to);
                fromsearch = DateTime.Parse(from);
               
            }
            if(groupname != null)
            {
                if (groupname == "null")
                    grpname = null;
                else
                    grpname = groupname;
            }


            if (to == null && from == null)
            {
                 ItemSales = service.GetItemSales(shftnum, tosearch, fromsearch, grpname);  ;
            }
            else
            {
                ItemSales = service.GetItemSales(shftnum, tosearch, fromsearch, grpname);
            }
              

            List<Sales_Bydate> ResultGroup = new List<Sales_Bydate>();
            List<DateTime?> UniquesDates = new List<DateTime?>();
            List<int?> UniquesshiftNums = new List<int?>();
            List<string?> Uniquesgroups = new List<string?>();

            foreach (var itm in ItemSales)
            {
               
               
                if(!UniquesDates.Contains(itm.DATE))
                {
                    UniquesDates.Add(itm.DATE);
                }

                if (!UniquesshiftNums.Contains(itm.shift_no))
                {
                    UniquesshiftNums.Add(itm.shift_no);
                }
                if(!Uniquesgroups.Contains(itm.Group_Name))
                {
                    Uniquesgroups.Add(itm.Group_Name);
                }

                var match = ResultGroup
             .FirstOrDefault(ItemCheck => ItemCheck.NAME.Contains(itm.NAME));
                if (match==null)
                {
                    ResultGroup.Add(itm);
                }
                else
                {
                    foreach(var item in ResultGroup)
                    {
                        if(itm.NAME==item.NAME)
                        {
                            item.NET_Qty += itm.NET_Qty;
                            item.total_cost += itm.total_cost;
                            item.total_price += itm.total_price;
                        }
                    }
                }
            }

            if(UniquesDates!=null)
            {
                ViewData["UniqueDates"] = UniquesDates;
            }

            if (UniquesDates != null)
            {
                ViewData["UniqueShifts"] = UniquesshiftNums;
            }

            if (Uniquesgroups != null)
            {
                ViewData["UniqueGroups"] = Uniquesgroups;
            }


            return View(ResultGroup);
        }

        [Route("PosBill")]
        public ActionResult PosBillDetails(string? shiftnum, string? to, string? from)
        {
            int shftnum = 0;
            DateTime? tosearch = null;
            DateTime? fromsearch = null;

            var Pos_Bills = new List<POS_Bills_Details>();

            if (shiftnum != null )
            {
                shftnum = Int32.Parse(shiftnum);

            }

            if (to != null && to!="" && from != null && from!="" )
            {
                tosearch = DateTime.Parse(to);
                fromsearch = DateTime.Parse(from);

            }
            else if(to != null && to != "")
            {
                tosearch = DateTime.Parse(to);
            }
            else if (from != null && from != "")
            {
                fromsearch = DateTime.Parse(from);
            }



                if (to == null && from == null)
            {
                 Pos_Bills = service.GetPosBillsDetails(shftnum, tosearch, fromsearch);
            }
            else
            {
                 Pos_Bills = service.GetPosBillsDetails(shftnum, tosearch, fromsearch);
            }


            List<POS_Bills_Details> ResultGroup = new List<POS_Bills_Details>();
            List<DateTime?> UniquesDates = new List<DateTime?>();
            List<int?> UniquesshiftNums = new List<int?>();
            List<string?> Uniquesgroups = new List<string?>();

            foreach (var itm in Pos_Bills)
            {


                if (!UniquesDates.Contains(itm.DATE))
                {
                    UniquesDates.Add(itm.DATE);
                }

                if (!UniquesshiftNums.Contains(itm.shift_no))
                {
                    UniquesshiftNums.Add(itm.shift_no);
                }
                

                var match = ResultGroup
             .FirstOrDefault(ItemCheck => ItemCheck.NAME.Contains(itm.NAME));
                if (match == null)
                {
                    ResultGroup.Add(itm);
                }

            }

            if (UniquesDates != null)
            {
                ViewData["UniqueDates"] = UniquesDates;
            }

            if (UniquesDates != null)
            {
                ViewData["UniqueShifts"] = UniquesshiftNums;
            }

            if (Uniquesgroups != null)
            {
                ViewData["UniqueGroups"] = Uniquesgroups;
            }


            
            return View(Pos_Bills);
        }

    }
}