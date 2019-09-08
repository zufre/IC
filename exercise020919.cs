using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace exercise020919
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection con =  new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=exercise020919;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();


            cmd.CommandText = "insert into Customers values ('"+txtName.Text+ "','" + txtEmail.Text + "','" + txtMobile.Text     + "'," + txtAge.Text + ",'" + txtCity.Text + "');";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            con.Open();

            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("record created!");

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=exercise020919;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();


            cmd.CommandText = "update Customers  set Name='" + txtName.Text + "', Email='" + txtEmail.Text + "', Mobile='" + txtMobile.Text + "', Age=" + txtAge.Text + ", City='" + txtCity.Text + "' Where ID =" + txtId.Text + ";";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            con.Open();

            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("record updated!");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=exercise020919;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();


            cmd.CommandText = "delete Customers Where ID =" + txtId.Text + ";";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            con.Open();

            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("record deleted!");
        }
    }
}
