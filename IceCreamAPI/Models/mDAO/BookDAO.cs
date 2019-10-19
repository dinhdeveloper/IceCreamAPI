using IceCreamAPI.Interface;
using IceCreamAPI.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IceCreamAPI.Models.mDAO
{
    public class BookDAO : ICRUD<BookDTO>
    {
        private static BookDAO Instance = new BookDAO();
        public static BookDAO GetInstance()
        {
            return Instance;
        }

        public BookDTO Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<BookDTO> GetAll()
        {
            List<BookDTO> ListBook = new List<BookDTO>();
            var sql = (from s in DbConnection.iceCreamDb.Books select s).ToList();
            foreach (var s in sql)
            {
                BookDTO book = new BookDTO
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

        public BookDTO GetId(string Id)
        {
            BookDTO bookDTO = new BookDTO();
            var sql = DbConnection.iceCreamDb.Books.Where(x => x.BookId == Id).FirstOrDefault();
            if(sql != null)
            {
                bookDTO.BookId = sql.BookId;
                bookDTO.Descr = sql.Descr;
                bookDTO.Title = sql.Title;
                bookDTO.ReleasedDate = Convert.ToDateTime(sql.ReleasedDate);
                bookDTO.Price = Convert.ToDouble(sql.Price);
                return bookDTO;
            }
            return bookDTO;
        }

        public BookDTO Insert(BookDTO t)
        {
            throw new NotImplementedException();
        }

        public BookDTO Update(BookDTO t)
        {
            throw new NotImplementedException();
        }
    }
}