using System;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;
namespace e_learn
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	public class Class1
	{
		//publicSqlConnection con=newSqlConnection("provider=Microsoft.Jet.Oledb.4.0;data source=c:/inetpub/wwwroot/uk.mdb");
   public     SqlConnection con = new SqlConnection("Data Source=Venkat;database=OnlineStuMgt;Integrated Security=True;User id=sa;Password=sas");
		SqlCommand cmd =new SqlCommand();
       SqlDataAdapter da;
	//	OleDbCommandBuilder cb;
		DataSet ds=new DataSet();
	//	OleDbDataReader dr;
	//	DataRow drow;

		public Class1()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		public int save(string sqlquery)
		{
            //try
            //{
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
                cmd.Connection = con;
                cmd.CommandText = sqlquery;
                int i = cmd.ExecuteNonQuery();
                con.Close();
               return i;
                //return (sqlquery);
            //}
            //catch (Exception ex)
            //{
            //    return (ex.Message.ToString());
            //}
		}
		public int chklogin(string uid,string pwd,string tname)
		{
				cmd.Connection=con;
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.CommandText="select count(*) from "+tname+" where empid='"+uid+"' and password='"+pwd+"'";
				int i=int.Parse(cmd.ExecuteScalar().ToString());
				con.Close();
				return i;
				}
		public int chkregcourse(string query11)
		{
				cmd.Connection=con;
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
				cmd.CommandText=query11;
				int i=int.Parse(cmd.ExecuteScalar().ToString());
				con.Close();
				return i;
				}

		public string chkstatus(string query)
		{
			cmd.Connection=con;
			con.Open();
			cmd.CommandText=query;
			string i=cmd.ExecuteScalar().ToString();
			con.Close();
			return i;
		}
		
		public  DataSet fill(string querystr)
		{
				da=new SqlDataAdapter(querystr,con);
				da.Fill(ds);
				con.Close();
				return ds;
		}
		public string ret(string query)
		{ 
				cmd.Connection=con;
				con.Open();
				cmd.CommandText=query;
				string i=cmd.ExecuteScalar().ToString();
				con.Close();
				return i;
				}

		public System.Data.DataSet  rowdetails(string query)
		{
				da=new SqlDataAdapter(query,con);
				da.Fill(ds);
				con.Close();
				return ds;
		}
		
	}
}