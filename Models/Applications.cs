using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApi.Models
{
    public class Applications
    {
        public Response GetAllProducts(SqlConnection conn)
        {
            Response response = new Response();
            string Query = "";
            SqlDataAdapter da = new SqlDataAdapter(Query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<Product> listProduct = new List<Product>();
            if(dt.Rows.Count > 0)
            {
                for (int i =0; i < dt.Rows.Count; i++)
                {
                    Product product = new Product();
                    product.ProductName = (string)dt.Rows[i]["ProductName"];
                    product.ProductId = (string)dt.Rows[i]["ProductId"];
                    product.Amount = (string)dt.Rows[i]["Amount"];
                    product.Price = (string)dt.Rows[i]["Price"];
                    listProduct.Add(product);
                }
              
            }
            if (listProduct.Count > 0)
            {
                response.StatusCode = 200;
                response.StatusMessage = "Product received Perfectly";
                response.listProduct = listProduct; 
            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "No product found";
                response.listProduct = null;
            }
            return response;
        }
    }
}
