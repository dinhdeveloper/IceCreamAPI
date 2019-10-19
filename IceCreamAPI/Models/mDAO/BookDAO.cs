using IceCreamAPI.Interface;
using IceCreamAPI.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IceCreamAPI.Models.mDAO
{
    public class BookDAO : ICRUD<BookDTO>
    {
        private static BookDAO Instance = new BookDAO();
        public static BookDAO GetInstance()
        {
            return Instance;
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

        public BookDTO Insert(BookDTO bookDTO)
        {

            try
            {
                Book book = new Book
                {
                    BookId = bookDTO.BookId,
                    Title = 'N' + bookDTO.Title,
                    Descr = 'N' + bookDTO.Descr,
                    ReleasedDate = bookDTO.ReleasedDate,
                    Price = bookDTO.Price
                };
                DbConnection.iceCreamDb.Books.Add(book);
                DbConnection.iceCreamDb.SaveChanges();
                return bookDTO;
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException e)
            {
                throw e;
            }
        }

        public BookDTO Update(BookDTO bookDTO)
        {
            var sql = DbConnection.iceCreamDb.Books.Where(x => x.BookId == bookDTO.BookId).FirstOrDefault();
            sql.BookId = bookDTO.BookId;
            sql.Descr = bookDTO.Descr;
            sql.ReleasedDate = bookDTO.ReleasedDate;
            sql.Title = bookDTO.Title;
            sql.Price = bookDTO.Price;

            DbConnection.iceCreamDb.SaveChanges();
            return bookDTO;
        }

        public bool Delete(string Id)
        {
           
            var sql = DbConnection.iceCreamDb.Books.Where(x => x.BookId == Id).FirstOrDefault();
            if(sql != null)
            {
                DbConnection.iceCreamDb.Books.Remove(sql);
                DbConnection.iceCreamDb.SaveChanges();
                return true;
            }
            return false;
        }

        public BookDTO GetId(int Id)
        {
            throw new NotImplementedException();
        }
    }
}