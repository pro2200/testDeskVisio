using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using ProductApi.Models;
using System.Data.SqlClient;
using ProductApi.Controllers;
using ProductApi.Models;



namespace ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public ProductController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        [Route("GetAllProduct")]
        public Response GetAllProducts()
        {
            SqlConnection conn = new SqlConnection(_configuration.GetConnectionString("productConn").ToString());
            Response response = new Response();
            Applications apl = new Applications();
            response = apl.GetAllProducts(conn);
            return response;
        }
    }
}
