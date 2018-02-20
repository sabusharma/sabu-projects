using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for BookStore
/// </summary>
public class BookStore
{   
    string machineName = Environment.MachineName;
    string connString;
    public BookStore()
	{
        connString = string.Format(@"Data Source={0}\SQLEXPRESS;AttachDbFilename=|DataDirectory|\BookStoreDB.mdf;Integrated Security=True;User Instance=True", machineName);
    }
    private SqlConnection DBConnection()
    {
        SqlConnection conn = new SqlConnection(connString);
        conn.Open();
        return conn;
    }

    public string CustomerRegistration(Customer cust)
    {
        SqlConnection conn = DBConnection();
        return cust.AddCustomer(cust, conn);
    }

    public bool ValidateCustomer(Customer cust)
    {
        SqlConnection conn = DBConnection();
        return cust.IsValidCustomer(cust.email, cust.password, conn);
    }

    public Customer CustomerBillingAddress(string email)
    {
        SqlConnection conn = DBConnection();
        Customer cust = new Customer();
        DataSet ds = cust.GetCustomerDetails(conn, email);
        cust.lastName = ds.Tables[0].Rows[0][0].ToString();
        cust.firstName = ds.Tables[0].Rows[0][1].ToString();
        cust.address = ds.Tables[0].Rows[0][2].ToString();
        cust.city = ds.Tables[0].Rows[0][3].ToString();
        cust.state = ds.Tables[0].Rows[0][4].ToString();
        cust.zip = ds.Tables[0].Rows[0][5].ToString();
        cust.phone = ds.Tables[0].Rows[0][6].ToString();
        return cust;
    }

    public void UpdateCustomerBillingAddress(Customer cust)
    {
        SqlConnection conn = DBConnection();
        cust.UpdateCustomerAddressInformation(conn, cust);
    }

    //public SqlDataReader DisplayProductList()
    //{
    //    Products prod = new Products();
    //    SqlConnection conn = DBConnection();
    //    return prod.ProductsList(conn);
    //}


    public SqlDataReader ProductDetails(string ProductID)
    {
        Product prod = new Product();
        SqlConnection conn = DBConnection();
        return prod.GetProductsDetails(conn, ProductID);
    }

    public int PlaceOrder(Customer cust, ShoppingCart shopcart, double totalcost)
    {
        Order newoder = new Order(totalcost);
        SqlConnection conn = DBConnection();
        return newoder.CreateNewOrder(cust, shopcart, newoder, conn);

    }

    public void CustomerMessage(CustomerMessageStore cust)
    {
        SqlConnection conn = DBConnection();
        cust.AddMessage (cust, conn);
    }

    //public bool AddProduct(Products prod)
    //{
    //    SqlConnection conn = DBConnection();
    //    return prod.AddProduct(prod, conn);
    //}   

}
public class Category
{
    //public int productID;
    //public int categoryID;
    public string categoryName;
    public string categoryDesc;
    

    
    public bool InsertCategory(Category c)
    {
        string cmd = String.Format("INSERT INTO Category (CategoryName, Description) VALUES ('{0}','{1}')",
             c.categoryName, c.categoryDesc);

        SqlConnection con = OpenDatabaseConnection();
        SqlCommand insertCmd = new SqlCommand(cmd, con);
        insertCmd.CommandType = CommandType.Text;

        try
        {
            insertCmd.ExecuteNonQuery();
            return true;

        }
        catch (Exception ex)
        {
            return false;
        }

        finally
        {
            CloseDatabaseConnection(con);

        }
    }

    public SqlConnection OpenDatabaseConnection()
    {
        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["BookStoreConnectionString"].ConnectionString;
        SqlConnection conn = new SqlConnection(connString);
        conn.Open();
        return conn;
    }

    public void CloseDatabaseConnection(SqlConnection conn)
    {
        conn.Close();
    }
}

public class Product
{
   
    public string categoryName;
    public string productName;
    public string shortDesc;
    public string detailedDesc;
    public string price;
    public string thumbnail;
    public string image;
    public string isbn;



    public SqlDataReader GetProductsDetails(SqlConnection conn, string ProductID)
    {
        string cmd = String.Format("Select * from Products Where ProductID={0}", ProductID);
        SqlCommand sqlcmd = new SqlCommand(cmd, conn);
        SqlDataReader read = sqlcmd.ExecuteReader();
        return read;
    }

   
    public bool InsertProduct(Product p)
    {
        string cmd = String.Format("INSERT INTO Products (CategoryID, ProductName, ShortDesc, DetailedDesc, UnitPrice, Thumbnail, Image,ISBN) VALUES ({0},'{1}','{2}','{3}',{4},'{5}','{6}',{7})",
             p.categoryName, p.productName, p.shortDesc, p.detailedDesc, p.price, p.thumbnail, p.image, p.isbn);

        SqlConnection con = OpenDatabaseConnection();
        SqlCommand insertCmd = new SqlCommand(cmd, con);
        insertCmd.CommandType = CommandType.Text;

        try
        {
            insertCmd.ExecuteNonQuery();
            return true;

        }
        catch (Exception ex)
        {
            return false;
        }

        finally
        {
            CloseDatabaseConnection(con);

        }
    }

    public SqlConnection OpenDatabaseConnection()
    {
        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["BookStoreConnectionString"].ConnectionString;
        SqlConnection conn = new SqlConnection(connString);
        conn.Open();
        return conn;
    }

    public void CloseDatabaseConnection(SqlConnection conn)
    {
        conn.Close();
    }
}

    


public class Customer
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

    public string shippingLastName;
    public string shippingFirstName;
    public string shippingAddress;
    public string shippingCity;
    public string shippingState;
    public string shippingZip;
    public string shippingPhone;

    public string AddCustomer(Customer cust, SqlConnection conn)
    {
        string msg = "";
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
            msg = "Success";
        }
        catch (SqlException e1)
        {
            if (e1.ToString().Contains("Violation of PRIMARY KEY constraint"))
                msg = "This email is already registered";
        }

        catch (Exception ex)
        {
            string e = ex.ToString();
            msg = "Error occurred during registration process";
        }

        return msg;
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

    public DataSet GetCustomerDetails(SqlConnection conn, string email)
    {
        string cmd = "SP_GetCustomerBillingAddress";
        SqlCommand sqlcmd = new SqlCommand(cmd, conn);
        sqlcmd.CommandType = CommandType.StoredProcedure;
        sqlcmd.Parameters.Add("@custEmail", SqlDbType.VarChar).Value = email;
        SqlDataAdapter adapter = new SqlDataAdapter(sqlcmd);
        DataSet ds = new DataSet();
        sqlcmd.ExecuteNonQuery();
        adapter.Fill(ds);
        return ds;
    }

    public void UpdateCustomerAddressInformation(SqlConnection conn, Customer cust)
    {
        string cmd = "SP_UpdateCustBillingAddress";
        SqlCommand sqlcmd = new SqlCommand(cmd, conn);
        sqlcmd.CommandType = CommandType.StoredProcedure;
        sqlcmd.Parameters.Add("@custEmail", SqlDbType.VarChar).Value = cust.email;
        sqlcmd.Parameters.Add("@address", SqlDbType.VarChar).Value = cust.address;
        sqlcmd.Parameters.Add("@city", SqlDbType.VarChar).Value = cust.city;
        sqlcmd.Parameters.Add("@state", SqlDbType.VarChar).Value = cust.state;
        sqlcmd.Parameters.Add("@zip", SqlDbType.VarChar).Value = cust.zip;
        sqlcmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = cust.phone;
        sqlcmd.ExecuteNonQuery();
        
    }
}

public class CartItems
{
    private string prodID;
    private string prodName;
    private double price;
    private int qty;

    public CartItems()
    {
        prodID = "";
        prodName = "";
        price = 0.0;
        qty = 0;
    }

    public CartItems(string productID, string productName, double unitPrice, int quantity)
    {
        prodID = productID;
        prodName = productName;
        price = unitPrice;
        qty = quantity;
    }

    public string ProductID
    {
        get { return prodID; }
        set { prodID = value; }
    }

    public string ProductName
    {
        get { return prodName; }
        set { prodName = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public int Quantity
    {
        get { return qty; }
        set { qty = value; }
    }

    public double SubTotal
    {
        get { return qty * price; }
    }
}

public class ShoppingCart
{
    private List<CartItems> item;

    public ShoppingCart()
    {
        item = new List<CartItems>();
    }

    public void AddItems(string id, string name, double price)
    {
        bool itemExist = false;

        for (int i = 0; i < item.Count; i++)
        {
            if (item[i].ProductID == id)
            {
                item[i].Quantity++;
                itemExist = true;
            }
        }

        if (!itemExist)
        {
            CartItems cartitem = new CartItems(id, name, price, 1);
            item.Add(cartitem);
        }
    
    }

    public List<CartItems> GetItems()
    {
        return item;
    }

    public void RemoveItem(int index)
    {
        item.RemoveAt(index);   
    }

    public int Count
    {
        get { return item.Count; }
    }
}


public class Order
{
    private double totalcost;
    private double shippingCost;
    

    public Order()
    {
        shippingCost = 10;
        totalcost = 0;
    }

    public Order(double subTotalCost)
    {
        shippingCost = 10;
        totalcost = subTotalCost;
    }

    public double TotalCost
    {
        get { return totalcost; }
        set { totalcost = value; }
    }

    public double SalesTax
    {
        get { return TotalCost * 0.08; }
    }

    public double ShippingCost
    {
        get { return shippingCost; }    
    }

    public double NetTotal
    {
        get { return TotalCost + SalesTax + ShippingCost; }
    }

    public int CreateNewOrder(Customer cust, ShoppingCart shopcart, Order or, SqlConnection conn)
    {
        string orderDate = DateTime.Now.ToString();
        int orderID = GetNewOrderID(conn, orderDate, cust.email, or.SalesTax, or.ShippingCost);
        InsertShipAddress(conn, orderID, cust);

        List<CartItems> cartitem = shopcart.GetItems();

        for (int i = 0; i < cartitem.Count; i++)
        {
            int prodiD = Convert.ToInt32(cartitem[i].ProductID);
            InsertOrderDetails(conn, orderID, prodiD, cartitem[i].Quantity);

        }

        return orderID;
    }

    private int GetNewOrderID(SqlConnection conn, string orderDate, string custEmail, double salesTax, double shippingCost)
    {
        SqlCommand cmd = new SqlCommand("SP_NewOrder", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@OrderDate", SqlDbType.DateTime).Value = orderDate;
        cmd.Parameters.Add("@CustEmail", SqlDbType.VarChar).Value = custEmail;
        cmd.Parameters.Add("@SalesTax", SqlDbType.Money).Value = Convert.ToDecimal(salesTax);
        cmd.Parameters.Add("@ShippingCost", SqlDbType.Money).Value = Convert.ToDecimal(shippingCost);
        
        cmd.ExecuteNonQuery();

        cmd = new SqlCommand("SP_GetOrderID", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@OrderDate", SqlDbType.DateTime).Value = orderDate;
        cmd.Parameters.Add("@CustEmail", SqlDbType.VarChar).Value = custEmail;
        cmd.Parameters.Add("@SalesTax", SqlDbType.Money).Value = Convert.ToDecimal(salesTax);

        return (int)cmd.ExecuteScalar();
    }

    private void InsertOrderDetails(SqlConnection conn, int orderID, int ProductID, int qty)
    {
        SqlCommand cmd = new SqlCommand("SP_NewOrderDetails", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@OrderID", SqlDbType.Int).Value = orderID;
        cmd.Parameters.Add("@ProductID", SqlDbType.Int).Value = ProductID;
        cmd.Parameters.Add("@Quantity", SqlDbType.Money).Value = qty;

        cmd.ExecuteNonQuery();
    }

    private void InsertShipAddress(SqlConnection conn, int orderID, Customer cust)
    {
        SqlCommand cmd = new SqlCommand("SP_NewShipAddress", conn);
        cmd.CommandType = CommandType.StoredProcedure;        
        cmd.Parameters.Add("@CustEmail", SqlDbType.VarChar).Value = cust.email;
        cmd.Parameters.Add("@OrderID", SqlDbType.Int).Value = orderID;
        cmd.Parameters.Add("@ShippingLastName", SqlDbType.VarChar).Value = cust.shippingLastName;
        cmd.Parameters.Add("@ShippingFirstName", SqlDbType.VarChar).Value = cust.shippingFirstName;
        cmd.Parameters.Add("@ShippingAddress", SqlDbType.VarChar).Value = cust.shippingAddress;
        cmd.Parameters.Add("@ShippingCity", SqlDbType.VarChar).Value = cust.shippingCity;
        cmd.Parameters.Add("@ShippingState", SqlDbType.VarChar).Value = cust.shippingState;
        cmd.Parameters.Add("@ShippingZip", SqlDbType.VarChar).Value = cust.shippingZip;
        cmd.Parameters.Add("@ShippingPhone", SqlDbType.VarChar).Value = cust.shippingPhone;
        cmd.ExecuteNonQuery();

        
    }
    
}

public class CustomerMessageStore
{
    public string email;
    public string lastName;
    public string firstName;
    public string subject;
    public string message;



    public void AddMessage(CustomerMessageStore cust, SqlConnection conn)
    {
        try
        {
            SqlCommand cmd = new SqlCommand("SP_CustomerMessage", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = cust.firstName;
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = cust.lastName;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = cust.email;
            cmd.Parameters.Add("@Subject", SqlDbType.VarChar).Value = cust.subject;
            cmd.Parameters.Add("@Message", SqlDbType.VarChar).Value = cust.message;

            cmd.ExecuteNonQuery();

        }
        catch (SqlException e1)
        {

        }

        catch (Exception ex)
        {
            string e = ex.ToString();
        }
    }

}