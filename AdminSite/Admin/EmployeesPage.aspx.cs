using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using Sandbox;

namespace AdminSite.Admin
{
    public partial class EmployeesPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            EmployeeRepeater.DataSource = DataTableUtils.GetEmployeeDataTable(new Employees().EmployeeList);
            EmployeeRepeater.DataBind();
        }
    }
}