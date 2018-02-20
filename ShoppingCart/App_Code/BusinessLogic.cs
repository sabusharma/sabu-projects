using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for BusinessLogic
/// </summary>
public class BusinessLogic
{
    string connString = "Data Source=.;Initial Catalog=ShoppingCartDB;Integrated Security=True";

	public BusinessLogic()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    
    public void CustomerRegistration(Customer cust)
    {
        SqlConnection conn = DBConnection();
        cust.AddCustomer(cust, conn);        
    }

    private SqlConnection DBConnection()
    {
        SqlConnection conn = new SqlConnection(connString);
        conn.Open();
        return conn;
    }

    public bool ValidateCustomer(Customer cust)
    {
        SqlConnection conn = DBConnection();
        return cust.IsValidCustomer(cust.email, cust.password, conn);
    }



}

public class Customer1
{
    public string email;
    public string lastName;
    public string firstName;
    public string address;
    public string city;
    public string state;
    public string zip;
    public string phone;
    public string password;
    public string secretQuestion;
    public string secretAnswer;

    public void AddCustomer(Customer cust, SqlConnection conn)
    {
        try
        {
            SqlCommand cmd = new SqlCommand("SP_CustomerRegistration", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = cust.email;
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = cust.lastName;
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = cust.firstName;
            cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = cust.address;
            cmd.Parameters.Add("@City", SqlDbType.VarChar).Value = cust.city;
            cmd.Parameters.Add("@State", SqlDbType.VarChar).Value = cust.state;
            cmd.Parameters.Add("@Zip", SqlDbType.VarChar).Value = cust.zip;
            cmd.Parameters.Add("@Phone", SqlDbType.VarChar).Value = cust.phone;
            cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = cust.password;
            cmd.Parameters.Add("@SecretQuestion", SqlDbType.VarChar).Value = cust.secretQuestion;
            cmd.Parameters.Add("@SecretAnswer", SqlDbType.VarChar).Value = cust.secretAnswer;

            cmd.ExecuteNonQuery();
            
        } 
        
        catch (Exception ex)
        {
            string e = ex.ToString();
        }
    }

    public bool IsValidCustomer(string email, string password, SqlConnection conn)
    {
        SqlCommand cmd = new SqlCommand("SP_ValidateCustomer", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
        cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        cmd.ExecuteNonQuery();
        adapter.Fill(ds);

        if (ds.Tables[0].Rows.Count == 1)
        {
            string dbEmail = ds.Tables[0].Rows[0][0].ToString();
            string dbPass = ds.Tables[0].Rows[0][1].ToString();

            if (dbEmail == email && dbPass == password)
                return true;
        }
        
        return false;
    }

}
