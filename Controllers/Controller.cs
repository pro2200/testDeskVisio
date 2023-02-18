using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using lab5.Controllers;
using lab5.model;

namespace lab5.Controllers
{
    public class Controller : ControllerBase
    {

        private readonly IConfiguration _configuration; //receive and request the connection

        public Controller(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // to read the data from the server student table 
        [HttpGet]
        [Route("GetAllfarmers")]

        public Response GetAllProduct()
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("farmerscon").ToString());
            Response response = new Response();
            Application apl = new Application();
            response = apl.GetAllProduct(con);
            return response;
        }
        // to insert data in my student table 
        [HttpPost]
        [Route("Addfarmers")]

        public Response AddProduct(Product product)
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("farmersCon").ToString());
            Response response = new Response();
            Application apl = new Application();
            response = apl.AddProduct(con, product);
            return response;
        }
        }
}
