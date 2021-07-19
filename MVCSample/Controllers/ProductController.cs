using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCSample.Models;
using MySql.Data.MySqlClient;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        public ProductController()
        {
        }



        // Rest service에서       
        // GET, POST, PUT, DELETE 뭔지 조사해오기
        // GET, POST를 2개 이상 구현해오기
        // DB를 붙일수도 있을 것 같음
        [HttpGet]
        public List<Product> GetProductList()
        {
            List<Product> products = new List<Product>();

            string connectionString = "Server=localhost;Port=3306;Database=coding32;Uid=root;Pwd=1111";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
//                MySqlCommand cmd = new MysqlCommand(sql, connnection);
//                MySqlDataReader table = cmd.ExecuteReader();
//                while (table.Read())
//                {
//                    table["id"].....

//}
            }
            return products;
        }




        //Anotation
        //[HttpGet]
        // public List<Product> GetProductList()
        // {
        //     List<Product> products = new List<Product>();

        //     for (int i = 0; i < 5; i++)
        //     {
        //         products.Add(new Product
        //         {
        //             id = i,
        //             productName = "싱픔" + i,
        //             category = "카테고리" + i,
        //             material = "소재" + i,
        //             price = 1000000 + i,
        //             seller = "심마리아지",
        //             deliveryFee = 3000
        //         });
        //     }

        //     return products;
    }

}

