using IceCreamAPI.Interface;
using IceCreamAPI.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IceCreamAPI.Models.mDAO
{
    public class BookDAO : ICRUD<Book>
    {
        IceCreamWebProjectEntities iceCreamDb = new IceCreamWebProjectEntities();
        //private static readonly BookDAO Instance = new BookDAO();

        //public static BookDAO GetInstance(){
           
        //    return Instance;
        //}

        public Book Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAll()
        {
            List<Book> ListBook = new List<Book>();
            var sql = (from s in iceCreamDb.Books select s).ToList();
            foreach(var s in sql)
            {
                Book book = new Book
                {
                    BookId = s.BookId,
                    Title = s.Title,
                    ReleasedDate = Convert.ToDateTime(s.ReleasedDate),
                    Descr = s.Descr,
                    Price = Convert.ToDouble(s.Price),
                };
                ListBook.Add(book);
            }
            return ListBook;
        }

        public Book GetId(int Id)
        {
            throw new NotImplementedException();
        }

        public Book Insert(Book book)
        {
            throw new NotImplementedException();
        }

        public Book Update(Book t)
        {
            throw new NotImplementedException();
        }
    }
}