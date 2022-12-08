using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
        Employee cr = new Employee();
        [HttpGet]
        public string Get()
        {
            string JSONresult;
            DataSet ds = new DataSet();
            ds = cr.getdata();
            JSONresult = JsonConvert.SerializeObject(ds.Tables[0]);


            //return ds;
            return JSONresult;
        }

        [HttpPost("Employee")]
        public string post(Regmodel rg)
        {
            Regmodel mr = new Regmodel();
            mr.Id = rg.Id;
            mr.Name = rg.Name;
            mr.Depid = rg.Depid;
            mr.Desid = rg.Desid;
            mr.Salary = rg.Salary;
            mr.Mail = rg.Mail;
            mr.Phone = rg.Phone;
            cr.insertEmployee(rg);
            //cr.delete3(mr);
            return "success";
        }
        [HttpPost("Department")]
        public string post(Regmodeldept rg)
        {
            Regmodeldept mr = new Regmodeldept();
            mr.Id = rg.Id;
            mr.Name = rg.Name;
            cr.insertDepartment(rg);
            return "success";
        }
        [HttpPost("Designation")]
        public string post(Regmodeldes rg)
        {
            Regmodeldes mr = new Regmodeldes();
            mr.Id = rg.Id;
            mr.Designation = rg.Designation;
            cr.insertDesignation(rg);
            return "success";
        }
        [HttpDelete("Delete")]
        public string delete(int Id)
        {
            cr.delete(Id);
            return "sucess";
        }
        [HttpPut]
        public string update(Regmodeldept rm)
        {
            cr.update(rm);
            return "success";
        }
    }
}