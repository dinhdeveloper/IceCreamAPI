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
        public IEnumerable<BookDTO> getAllBook()
        {

            return BookDAO.GetInstance().GetAll();
        }
        [HttpGet]
        [ActionName("GetOneBook")]
        public BookDTO getOneBook(string Id)
        {
            return BookDAO.GetInstance().GetId(Id);
        }
        [HttpPost]
        [ActionName("InsertBook")]
        public BookDTO insertBook(BookDTO bookDTO)
        {
            return BookDAO.GetInstance().Insert(bookDTO);
        }

        [HttpPut]
        [ActionName("UpdateBook")]
        public BookDTO UpdateBook(BookDTO bookDTO)
        {
            return BookDAO.GetInstance().Update(bookDTO);
        }
        [HttpDelete]
        [ActionName("DeleteBook")]
        public bool DeleteBook(string Id)
        {
            return BookDAO.GetInstance().Delete(Id);
        }
    }
}
