using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;


namespace lab5.model
{
    public class Application
    {

        public Response GetAllProduct(SqlConnection con)
        {
            Response response = new Response();
            string Query = "Select * from farmers"; // name of sql table 
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<Product> lstPro = new List<Product>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Product product = new Product(); // creating new class object
                    product.Amount = (int)dt.Rows[i]["Amount"];
                    product.ProductName = (string)dt.Rows[i]["ProductName"];
                    product.Price = (int)dt.Rows[i]["Price"];
                    product.ProductId = (int)dt.Rows[i]["ProductId"];

                    lstPro.Add(product);
                }
            }
            if (lstPro.Count > 0)
            {
                response.StatusCode = 200;
                response.StatusMessage = "Retrived Perfectltly";
                response.listProduct = lstPro;
            }

            else //only works if your data table is empty or conneciton fails 
            {
                response.StatusCode = 100;
                response.StatusMessage = "No  Retrived";
                response.listProduct = null;


            }
            return response;

        }
        public Response AddProduct(SqlConnection con, Product product)
        {
            Response response = new Response();
            string Query = "Insert into farmers(ProductId, ProductName, Amount, Price) Values(@ProductId, @ProductName, @Amount, @Price)";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@ProductId", product.ProductId);
            cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
            cmd.Parameters.AddWithValue("@Amount", product.Amount);
            cmd.Parameters.AddWithValue("@Price", product.Price);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                response.StatusCode = 200;
                response.StatusMessage = "Date inserted Properly";
            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "No Data Inserted";
            }
            return response;
        }
        }
}
