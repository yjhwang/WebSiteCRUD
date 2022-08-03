using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm1
{
    public partial class departLstR : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        DataSet ds = new DataSet();
        string myConditionString="";
        protected void btnQry_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(txtNum.Text);
                string sqlString;
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = @"Server=localhost\SQLEXPRESS;" +
                        "database=DB1; Integrated Security=True";
                    cn.Open();
                    sqlString = "SELECT TOP " + num;
                    // sqlString += " * "; // 全部的欄位
                    sqlString += "depNo as 部門號, ";
                    sqlString += "depName as 名稱, ";
                    sqlString += "depRemark as 備註 ";
                    sqlString += " FROM depart ";
                    myConditionString += " Where ";
                    myConditionString += " depName like @pTxtQry ";
                    myConditionString += " OR depNo like @pTxtQry;";
                    sqlString += myConditionString;
                    //sqlString += " depName LIKE '%" + txtQry.Text +"%'";
                    //sqlString += " OR depNo LIKE '%" + txtQry.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sqlString, cn);
                    cmd.Parameters.AddWithValue("@pTxtQry", "%" + txtQry.Text.Trim() + "%"); //過濾前後空白
                    cmd.CommandText = sqlString;
                    // 再將資料查詢結果放入ds(DataSet)物件中
                    SqlDataAdapter daDep = new SqlDataAdapter("", cn);
                    daDep.SelectCommand = cmd;
                    ds.Clear();
                    daDep.Fill(ds, "部門清單"); //使用cmd取出資料表的內容,存放到ds, 命名為"部門清單"

                    Repeater1.DataSource = ds.Tables["部門清單"];
                    Repeater1.DataBind();
                    lbRecords.Text = "符合查詢條件的有 " + ds.Tables["部門清單"].Rows.Count.ToString() + " 筆資料";
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                Response.Write(ex.Message);
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("departAdd.aspx");
        }

        protected void btnDelAll_Click(object sender, EventArgs e)
        {
            Response.Redirect("departDelAll.aspx");

        }

        protected void btnDelAll_Click1(object sender, EventArgs e)
        {

        }
    }
}