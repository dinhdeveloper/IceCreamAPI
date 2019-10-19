using IceCreamAPI.Interface;
using IceCreamAPI.Models.EF;
using IceCreamAPI.Models.mView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IceCreamAPI.Models.mDAO
{
    public class PaymentAccountDAO : ICRUD<mView.PaymentAccountDTO>
    {
        private static PaymentAccountDAO Instance = new PaymentAccountDAO();
        public static PaymentAccountDAO GetInstance()
        {
            return Instance;
        }
        public List<PaymentAccountDTO> GetAll()
        {
            List<PaymentAccountDTO> ListBook = new List<PaymentAccountDTO>();
            var sql = (from s in DbConnection.iceCreamDb.PaymentAccounts select s).ToList();
            foreach (var s in sql)
            {
                PaymentAccountDTO accountDTO = new PaymentAccountDTO
                {
                    PaymentAccId = s.PaymentAccId,
                    CardHolder = s.CardHolder,
                    CardNumber = Convert.ToInt16(s.CardNumber),
                };
                ListBook.Add(accountDTO);
            }
            return ListBook;
        }

        public PaymentAccountDTO GetId(int Id)
        {
            PaymentAccountDTO accountDTO = new PaymentAccountDTO();
            var sql = DbConnection.iceCreamDb.PaymentAccounts.Where(x =>x.PaymentAccId == Id).FirstOrDefault();
            if (sql != null)
            {
                accountDTO.PaymentAccId = sql.PaymentAccId;
                accountDTO.CardHolder = sql.CardHolder;
                accountDTO.CardNumber = Convert.ToInt16(sql.CardNumber);
               
                return accountDTO;
            }
            return accountDTO;
        }

        public PaymentAccountDTO Insert(PaymentAccountDTO accountDTO)
        {
            PaymentAccount payment = new PaymentAccount
            {
                PaymentAccId = accountDTO.PaymentAccId,
                CardHolder =  accountDTO.CardHolder,
                CardNumber =  accountDTO.CardNumber,
    
            };
            DbConnection.iceCreamDb.PaymentAccounts.Add(payment);
            DbConnection.iceCreamDb.SaveChanges();
            return accountDTO;
        }

        public PaymentAccountDTO Update(PaymentAccountDTO accountDTO)
        {
            var sql = DbConnection.iceCreamDb.PaymentAccounts.Where(x => x.PaymentAccId == accountDTO.PaymentAccId).FirstOrDefault();
            sql.PaymentAccId = accountDTO.PaymentAccId;
            sql.CardHolder = accountDTO.CardHolder;
            sql.CardNumber = accountDTO.CardNumber;
            DbConnection.iceCreamDb.SaveChanges();
            return accountDTO;
        }
        public bool Delete(string Id)
        {
            var sql = DbConnection.iceCreamDb.PaymentAccounts.Where(x => x.PaymentAccId == Convert.ToInt32(Id)).FirstOrDefault();
            if (sql != null)
            {
                DbConnection.iceCreamDb.PaymentAccounts.Remove(sql);
                DbConnection.iceCreamDb.SaveChanges();
                return true;
            }
            return false;
        }

        public PaymentAccountDTO GetId(string Id)
        {
            throw new NotImplementedException();
        }
    }
}