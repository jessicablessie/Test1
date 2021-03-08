
using System.Web.Mvc;
using Test1.Models;
//using System.Data.SqlClient;
//using System.Configuration;
//using System.Data;
using System.IO;
using Newtonsoft.Json;
using System;

namespace Test1.Controllers
{
    public class PatientController : Controller
    {


		////This returns the connection string  
		//private static string _connectionString = string.Empty;

		//public static string ConnectionString
		//{
		//	get
		//	{
		//		if (_connectionString == string.Empty)
		//		{
		//			_connectionString = ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString;
		//		}
		//		return _connectionString;
		//	}
		//}

		//private SqlConnection conn;
		//private void connection()
		//{
		//	conn = new SqlConnection(ConnectionString);

		//}

		public ActionResult AddNewPatient(PatientModel pat)
		{
			if (ModelState.IsValid)
			{

				try
				{
					string JsonResult = JsonConvert.SerializeObject(pat);
					string path = Server.MapPath("~/App_Data/patient.json");

					using (var tw = new StreamWriter(path, true))
					{
						tw.WriteLine(JsonResult.ToString());
						tw.Close();
					}
				}
				catch { }


				//connection();
				//SqlCommand cmd = new SqlCommand("InsertPatient", conn);
				//cmd.CommandType = CommandType.StoredProcedure;
				//cmd.Parameters.AddWithValue("@FirstName",pat.FirstName);
				//cmd.Parameters.AddWithValue("@LastName", pat.LastName);
				//conn.Open();

				//int i = cmd.ExecuteNonQuery();
				//conn.Close();
				//if (i >= 1)
				//{

				//	ViewBag.Message = "Record has been added successfully.";

				//}

				//GenerateJson(pat);
			}

			ModelState.Clear();
			return View();
		}

	}
}