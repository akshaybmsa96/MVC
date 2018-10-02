using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotNetMVCSheet.Models;

namespace DotNetMVCSheet.Controllers
{
    public class HomeController : Controller
    {

        Db_Access_Layer.Db dblayer = new Db_Access_Layer.Db();
       

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "LOGIN PAGE";

            return View();
        }

        public ActionResult SignUp()
        {
            ViewBag.Message = "SIGN UP";

            return View();
        }

        [HttpPost]
        public String Result(EmpModel emp)
        {
            string nm = emp.name; 
            return nm;
        }

       
        public ActionResult AddEMPView()
        {
           
            return View();
        }


        [HttpPost]
        public String AddEMP(EmpModel emp)
        {
            string nm = emp.name;
            string wk = emp.work;
            return nm+" "+wk;
        }

        public ActionResult List()
        {
          //  String query = "select * from emp";
            dblayer.con.Open();
           SqlCommand sm = new SqlCommand("GetEmp",  dblayer.con);
            sm.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = sm.ExecuteReader();
         
            //    Console.WriteLine(reader);

            var model = new List<EmpModel>();

            while (reader.Read())
            {
                var emp = new EmpModel();
                emp.name = (string)reader["name"];
                emp.work = (string)reader["work"];

            model.Add(emp);
            }

            dblayer.con.Close();

            return View(model);
        }

    }
}