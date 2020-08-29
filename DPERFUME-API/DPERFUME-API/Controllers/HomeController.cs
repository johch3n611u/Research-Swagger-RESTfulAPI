using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DPERFUME_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public HomePage homepage;

        [HttpGet]
        public ResultModel<HomePage> Get(string q)
        {
            ResultModel<HomePage> Response = new ResultModel<HomePage>();
            // ...
            return Response;
        }

        [HttpGet("{id}")]
        public ResultModel<HomePage> Get(int id)
        {
            ResultModel<HomePage> Response = new ResultModel<HomePage>();
            // ...
            return Response;
        }

        [HttpPost]
        public ResultModel<HomePage> Post([FromBody]HomePage user)
        {
            ResultModel<HomePage> Response = new ResultModel<HomePage>();
            // ...
            return Response;
        }

        [HttpPut("{id}")]
        public ResultModel<HomePage> Put(int id, [FromBody]HomePage user)
        {
            ResultModel<HomePage> Response = new ResultModel<HomePage>();
            // ...
            return Response;
        }

        [HttpDelete("{id}")]
        public ResultModel<HomePage> Delete(int id)
        {
            ResultModel<HomePage> Response = new ResultModel<HomePage>();
            // ...
            return Response;
        }


        public HomeController()
        {
            homepage = new HomePage();
            homepage.Layout = new Layout();
            homepage.Layout.Header = new Header();
            homepage.Layout.Header.Navbar = new Navbar();
            homepage.Layout.Header.Navbar.NavNames = new List<string>();
            homepage.Layout.Header.Navbar.ShopBag = new ShopBag();
            homepage.Layout.Header.Navbar.ShopBag.ProductNames = new List<string>();
            homepage.Layout.Footer = new Footer();
            homepage.Layout.Footer.Navbar = new Navbar();
            homepage.Layout.Footer.Navbar.NavNames = new List<string>();
            homepage.Layout.Footer.Navbar.ShopBag = new ShopBag();
            homepage.Layout.Footer.Navbar.ShopBag.ProductNames = new List<string>();
            homepage.ColumnProducts = new List<ColumnProduct>();
            homepage.Step = new List<Step>();
            homepage.RowProducts = new List<RowProduct>();
            homepage.FinalProduct = new FinalProduct();
        }

        #region DTO
        public class ResultModel<T>
        {
            public bool IsSuccess { get; set; }
            public string Message { get; set; }
            public T Data { get; set; }
        }

        public class Layout
        {
            public Header Header { get; set; }

            public Footer Footer { get; set; }

        }
        public class Header
        {
            public string Title { get; set; }
            public Navbar Navbar { get; set; }
        }
        public class Navbar
        {
            public List<string> NavNames { get; set; }

            public ShopBag ShopBag { get; set; }
        }

        public class ShopBag
        {
            public List<string> ProductNames { get; set; }
        }

        public class Footer
        {
            public string Copyright { get; set; }
            public string Title { get; set; }
            public Navbar Navbar { get; set; }
        }

        public class ColumnProduct
        {
            public string Title { get; set; }
            public string ProductInfo { get; set; }
            public string ProductLink { get; set; }
        }

        public class Step
        {
            public string Title { get; set; }
            public string StepInfo { get; set; }

        }

        public class RowProduct
        {
            public string Title { get; set; }
            public string ProductInfo { get; set; }
            public string ProductLink { get; set; }
            public string ProductPrice { get; set; }

        }

        public class FinalProduct
        {
            public string Title { get; set; }
            public string ProductInfo { get; set; }
            public string ProductLink { get; set; }

        }

        public class HomePage
        {
            public Layout Layout { get; set; }
            public List<ColumnProduct> ColumnProducts { get; set; }
            public List<Step> Step { get; set; }
            public List<RowProduct> RowProducts { get; set; }
            public FinalProduct FinalProduct { get; set; }
        }

        #endregion DTO
    }
}
