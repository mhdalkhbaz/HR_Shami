using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HRApp.Data;
using HRApp.Models;
using Newtonsoft.Json;
using DevExtreme;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

namespace HRApp.Controllers
{
    [Authorize]


    public class vi_emp_this_monthController : Controller
    {
        private readonly ApplicationDbContext _context;

        public vi_emp_this_monthController(ApplicationDbContext context)
        {
            _context = context;
        }

        //private readonly ILogger<vi_emp_this_monthController> _logger;

        //public vi_emp_this_monthController(ILogger<vi_emp_this_monthController> logger)
        //{
        //    _logger = logger;
        //}



        // GET: vi_emp_this_month
        public async Task<IActionResult> Live(DateTime? SearchString)
        {




            var BranchName = "";

            var Branches1 = await _context.vi_emp_this_month.OrderBy(x => x.depName).Where(x => x.depName != "Null").Where(x => x.depId == 1).Select(x => x.depName).ToListAsync();
            var Branches2 = await _context.vi_emp_this_month.OrderByDescending(x => x.depName).Where(x => x.depName != "Null").Where(x => x.depId == 2).Select(x => x.depName).ToListAsync();


            var Employees = _context.vwEmp.Where(y => y.EndWork.Year != 1901).Count();
            ViewBag.Employees = 0;
            ViewBag.Employees = Employees;



            var EmployeesMorning = _context.vi_emp_this_month.Where(y => y.depId != 1).Where(y => y.DayDate == DateTime.Now.Date).Where(y => y.InHour.Hour < 13).Count();
            ViewBag.EmployeesMorning = 20;



            var EmployeesEvning = _context.vi_emp_this_month.Where(y => y.depId != 1).Where(y => y.DayDate == DateTime.Now.Date).Where(y => y.InHour.Hour > 13).Count();
            ViewBag.EmployeesEvning = 28;

 



            var StartWorkEmp = _context.vwEmp.Where(y => y.StartWork.Year == DateTime.Now.Year).Where(y => y.StartWork.Month == DateTime.Now.Month).Count();
            var EndWorkEmp = _context.vwEmp.Where(y => y.EndWork.Year == DateTime.Now.Year).Where(y => y.EndWork.Month == DateTime.Now.Month).Count();

            if (StartWorkEmp != null ) { 
            ViewBag.StartWorkEmp = StartWorkEmp;
            }
            else
            {ViewBag.StartWorkEmp = 0;  }
            if (EndWorkEmp != null)
            {
                ViewBag.EndWorkEmp = EndWorkEmp;
            }
            else
            { ViewBag.EndWorkEmp = 0; }


            //ViewBag.chart_EmpLate = await _context.vi_emp_this_month.Where(y => y.DayDate.Month == 1 ).Where(y => y.State == 1).Select(x => new ViewContent
            //{
            //    Name = x.Name,
            //    depName = x.depName,
            //    DayDate = x.DayDate

            //}).ToListAsync();



            List<ViewContent> Data;

            if (SearchString == null)
            {
                  SearchString = DateTime.Now.Date;
            }

            Data = await _context.vi_emp_this_month.
                OrderBy(m => m.depName).
                Where(y => y.DayDate == SearchString ).
                Where(y => y.State == 1).
                Select(x => new ViewContent
                {
                    Name = x.Name,
                    depName = x.depName,
                    depId = x.depId,
                    Time_InHour = x.Time_InHour.ToString(),
                    Time_OutHour = x.Time_OutHour.ToString(),
                    InHour = x.InHour,
                    OutHour = x.OutHour
                }).ToListAsync();
          
            //else
            //{
            //      Data = await _context.vi_emp_this_month.OrderBy(m => m.depName).Where(y => y.DayDate == SearchString).Where(y => y.State == 1).Select(x => new ViewContent
            //    {
            //        Name = x.Name,
            //        depName = x.depName,
            //        depId = x.depId,
            //        Time_InHour = x.Time_InHour.ToString(),
            //        Time_OutHour = x.Time_OutHour.ToString(),
            //        InHour = x.InHour,
            //        OutHour = x.OutHour

            //    }).ToListAsync();
            //}
            //var  Data = await _context.vi_emp_this_month.Where(y => y.DayDate == FromDate).Where(y => y.State == 1).Select(x => new ViewContent { 
            //            Name = x.Name, 
            //            depName = x.depName,
            //            Time_InHour = x.Time_InHour.ToString(),
            //            Time_OutHour = x.Time_OutHour.ToString()

            //        }).ToListAsync();


            HashSet<string> AllBranches1 = new HashSet<string>();

            HashSet<string> AllBranches2 = new HashSet<string>();


            foreach (var item in Branches1)
            {
                BranchName = item ;
                if (item == null) continue;
                AllBranches1.Add(BranchName);
            }

              BranchName = "";


            foreach (var item in Branches2)
            {
                BranchName = item;
                if (item == null) continue;
                AllBranches2.Add(BranchName);
            }

            Dictionary<string, List<ViewContent>> ListDict1 = new Dictionary<string, List<ViewContent>>();
            Dictionary<string, List<ViewContent>> ListDict2 = new Dictionary<string, List<ViewContent>>();

            foreach (var item in AllBranches1)
            {
                ListDict1.Add(item, Data.Where(x => x.depName == item && x.depName != null).ToList());
            }

            foreach (var item in AllBranches2)
            {
                ListDict2.Add(item, Data.Where(x => x.depName == item && x.depName != null).ToList());
            }

            var ssada = new ListViewContent(ListDict2);


          

            var testDate = DateTime.Now.Month.ToString();

            List<ViewContent> LateHourList = await _context.vi_emp_this_month.Where(y => y.InHour.Year == DateTime.Now.Year).Where(y => y.InHour.Month == DateTime.Now.Month).
                Where(l => l.LateHour != 0).
                GroupBy(g => g.Name).
                Select(s => new ViewContent
                {
                    Name = s.Key,
                    LateHour = Convert.ToInt32(s.Count()) ,

                }).
                                            OrderByDescending(o => o.LateHour).
                                            Take(5).
                ToListAsync();
             

            ViewBag.LateEmp = LateHourList.ToArray();



            List<ViewContent> pluseHourList = await _context.vi_emp_this_month.Where(y => y.InHour.Year == DateTime.Now.Year).Where(y => y.InHour.Month == DateTime.Now.Month).Where(g => g.depId != 1 ).
                Where(l => l.OverTime1 != 0).
                GroupBy(g => g.Name).
                Select(s => new ViewContent
                {
                    Name = s.Key,
                    OverTime1 = s.Count(),

                }).
                                            OrderByDescending(o => o.OverTime1).
                                            Take(5).
                ToListAsync();
            if(pluseHourList != null) { 
            ViewBag.OverTimeEmp = pluseHourList.ToArray();
            }
            else
            {
                ViewBag.OverTimeEmp = " ";
            }

            //List<DataPoint> dataPoints = new List<DataPoint>();

            //dataPoints.Add(new DataPoint("Economics", 1));
            //dataPoints.Add(new DataPoint("Physics", 2));
            //dataPoints.Add(new DataPoint("Literature", 4));
            //dataPoints.Add(new DataPoint("Chemistry", 4));
            //dataPoints.Add(new DataPoint("Literature", 9));
            //dataPoints.Add(new DataPoint("Physiology or Medicine", 11));
            //dataPoints.Add(new DataPoint("Peace", 13));

            //ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);





            return View(ssada);



        }

        public ActionResult Index()
        {
            
            return View();
        }

    }


}
