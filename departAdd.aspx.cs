using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm1
{
    public partial class departAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        string sqlString;
        protected void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = @"Server=localhost\SQLEXPRESS;" +
                        "database=DB1; Integrated Security=True";
                    cn.Open();
                    sqlString = "INSERT INTO depart (depNo, depName, depRemark) ";
                    sqlString += " Values(@dNo, @dName, @dRemark)";
                    SqlCommand cmd = new SqlCommand(sqlString, cn);

                    cmd.Parameters.AddWithValue("@dNo", txtID.Text);
                    cmd.Parameters.AddWithValue("@dName", txtName.Text);
                    cmd.Parameters.AddWithValue("@dRemark", txtRemark.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
                // MessageBox.Show("新增資料, 使用SQLparameter, OK!");

                // System.Web.UI.ScriptManager.RegisterStartupScript(this, this.GetType(), "OpenNewWindow", "alert('新增資料OK！');", true);
                ShowMsg('完成新增!', function(yes) {

                    if (yes)
                    {



                    }

                });
                // ClientScript.RegisterStartupScript(GetType(), "message", "<script>alert('新增資料OK！');</script>");
                Response.Redirect("DepartLst.aspx");
            }
            catch (Exception ex)
            {
                // MessageBox.Show(sqlString + ex.Message);
                Response.Write("新增資料錯誤!"+sqlString + ex.Message);
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("DepartLst.aspx");
        }
    }
}