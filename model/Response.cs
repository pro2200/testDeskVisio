﻿namespace lab5.model
{
    public class Response
    {

        public int StatusCode { get; set; }
        public string StatusMessage { get; set; }

        public Product product { get; set; }
        public List<Product> listProduct { get; set; }

    }
}
