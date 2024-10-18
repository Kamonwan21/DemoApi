using DemoApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;

namespace DemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        public readonly IConfiguration _configuration;
        public EmployeesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost("GetAllEmployees")]
        public string GetEmployees()
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection").ToString());
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Employees", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<Employee> employeesList = new List<Employee>();
            Response response = new Response();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Employee employee = new Employee();
                    employee.order_item_id = Convert.ToInt32(dt.Rows[i]["order_item_id"]);
                    employee.AtBedTime = Convert.ToString(dt.Rows[i]["AtBedTime"]);
                    employee.MB = Convert.ToString(dt.Rows[i]["Mb"]);
                    employee.MA = Convert.ToString(dt.Rows[i]["Ma"]);
                    employee.AB = Convert.ToString(dt.Rows[i]["Ab"]);
                    employee.AA = Convert.ToString(dt.Rows[i]["Aa"]);
                    employee.EB = Convert.ToString(dt.Rows[i]["Eb"]);
                    employee.EA = Convert.ToString(dt.Rows[i]["Ea"]);
                    employee.age = Convert.ToInt32(dt.Rows[i]["age"]);
                    employee.hn = Convert.ToString(dt.Rows[i]["hn"]);
                    employee.gender = Convert.ToString(dt.Rows[i]["gender"]);
                    employee.birthofdate = Convert.ToString(dt.Rows[i]["birthofdate"]);
                    employee.ward = Convert.ToString(dt.Rows[i]["ward"]);
                    employee.patient_name = Convert.ToString(dt.Rows[i]["patient_name"]);
                    employee.Password = Convert.ToString(dt.Rows[i]["Password"]);
                    employee.item_name = Convert.ToString(dt.Rows[i]["item_name"]);
                    employee.th_name = Convert.ToString(dt.Rows[i]["th_name"]);
                    employee.Diagnosis = Convert.ToString(dt.Rows[i]["Diagnosis"]);
                    employee.Allergy = Convert.ToString(dt.Rows[i]["Allergy"]);
                    employee.instruction_text_line1 = Convert.ToString(dt.Rows[i]["instruction_text_line1"]);
                    employee.instruction_text_line2 = Convert.ToString(dt.Rows[i]["instruction_text_line2"]);
                    employee.instruction_text_line3 = Convert.ToString(dt.Rows[i]["instruction_text_line3"]);
                    employee.item_description = Convert.ToString(dt.Rows[i]["item_description"]);
                    employee.item_caution = Convert.ToString(dt.Rows[i]["item_caution"]);
                    employeesList.Add(employee);
                }
            }
            if (employeesList.Count > 0)
                return JsonConvert.SerializeObject(employeesList);
            else
            {
                response.StatusCode = 100;
                response.ErrorMessage = "No data found";
                return JsonConvert.SerializeObject(response);
            }
        }
}
}