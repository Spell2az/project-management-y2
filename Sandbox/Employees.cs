using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Sandbox
{
    public class Employees
    {
        public List<Employee> EmployeeList { get; set; }

        public Employees()
        {
            LoadJson();
        }
        public void LoadJson()
        {
            using (StreamReader r = new StreamReader($"{AppDomain.CurrentDomain.BaseDirectory}{this.GetType().Name.ToLowerInvariant()}-data.json"))
            {
                string json = r.ReadToEnd();
                EmployeeList = JsonConvert.DeserializeObject<List<Employee>>(json);
            }
        }

       
    }
}