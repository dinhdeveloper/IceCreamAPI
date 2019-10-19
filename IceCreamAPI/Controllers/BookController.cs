using IceCreamAPI.Models;
using IceCreamAPI.Models.mDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IceCreamAPI.Controllers
{
    public class BookController : ApiController
    {
        [HttpGet]
        [ActionName("getAllBook")]
        public IEnumerable<Book> getAllBook()
        {
            BookDAO bookDAO = new BookDAO();
            return bookDAO.GetAll();
        }
    }
}
