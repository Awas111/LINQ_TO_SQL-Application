using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wwr
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        private void GetData()
        {
            DataClasses1DataContext dbcontext = new DataClasses1DataContext();
            // this will write generated SQL query to web page
            //dbcontext.Log = Response.Output;
            GridView1.DataSource = dbcontext.getEmployees();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            GetData();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext dbcontext = new DataClasses1DataContext()) {

                Employee newemployee = new Employee
                {
                    firstname = "muaz",
                    lastname = "waseem",
                    address = "sdsd",
                    city = "mancester",
                    title= "md",
                    titleofcourtesy = "Mr.",
                    country="UK",
                    birthdate = DateTime.Today,
                    phone = "206) 555 - 0101",
                    mgrid =13,
                    postalcode= "m1933",
                    hiredate= DateTime.Today,
                    region ="WA"
                }; 
                dbcontext.Employees.InsertOnSubmit(newemployee);
                dbcontext.SubmitChanges();
            }
            GetData();

        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext dbcontext = new DataClasses1DataContext())
            {


                Employee employee = dbcontext.Employees.SingleOrDefault(x => x.lastname == "waseem");
                dbcontext.Employees.DeleteOnSubmit(employee);
                dbcontext.SubmitChanges();
            }
            GetData();
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext dbcontext = new DataClasses1DataContext())
            {


                Employee employee= dbcontext.Employees.SingleOrDefault(x => x.lastname == "waseem");
                employee.city = "London";
                dbcontext.SubmitChanges();
            }
            GetData();

        }
    }
}